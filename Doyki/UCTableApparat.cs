using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Doyki
{
    public partial class UCTableApparat : UserControl
    {
        public UCTableApparat()
        {
            InitializeComponent();
            this.apparatTableAdapter.Fill(this.uchot_udoevDataSet2.Apparat);
        }

        private void ApparatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.apparatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet2);
        }

        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < apparatDataGridView.RowCount; i++)
            {
                apparatDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < apparatDataGridView.ColumnCount; j++)
                    if (apparatDataGridView.Rows[i].Cells[j].Value != null)
                        if (apparatDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchStripTextBox.Text))
                        {
                            apparatDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = (MainForm)this.Parent;
            main.tableLayoutPanel1.Show();
        }

        private void DailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Сохранение";
            saveFileDialog1.FileName = "";
            saveFileDialog1.DefaultExt = "*.pdf";
            saveFileDialog1.Filter = "Файлы pdf (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SaveFileName = saveFileDialog1.FileName;

                //Объект документа пдф
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                //Создаем объект записи пдф-документа в файл
                PdfWriter.GetInstance(doc, new FileStream(SaveFileName, FileMode.Create));

                //Открываем документ
                doc.Open();

                //Определение шрифта необходимо для сохранения кириллического текста
                //Иначе мы не увидим кириллический текст
                //Если мы работаем только с англоязычными текстами, то шрифт можно не указывать
                string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
                BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
                iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL); //регистрируем + можно задать параметры для него(17 - размер, последний параметр - стиль)
                                                                                                                          //Создаем объект таблицы и передаем в нее число столбцов таблицы из нашего датасета
                PdfPTable table = new PdfPTable(3);//MyDataSet.Tables[i].Columns.Count);
                                                                                 //Добавим в таблицу общий заголовок
                PdfPCell cell = new PdfPCell(new Phrase("Суточный средний удой"));
                cell.Colspan = 3;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы был как заголовок
                cell.Border = 0;
                table.AddCell(cell);
                //Сначала добавляем заголовки таблицы
                cell = new PdfPCell(new Phrase(new Phrase("Номер коровы", fontParagraph)));
                //Фоновый цвет (необязательно, просто сделаем по красивее)
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Средний удой за день", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Суммарный удой за день", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                //Добавляем все остальные ячейки
                int[] id_cows = new int[apparatDataGridView.RowCount];
                int count_cows = 0;
                for (int j = 0; j < apparatDataGridView.RowCount - 1; j++)
                {
                    if (Convert.ToDateTime(apparatDataGridView.Rows[j].Cells[4].Value).Date == DateTime.Today && !id_cows.Contains(Convert.ToInt32(apparatDataGridView.Rows[j].Cells[2].Value)))
                    {
                            int id_cow = Convert.ToInt32(apparatDataGridView.Rows[j].Cells[2].Value), count = 0;
                            double sum_udoy = 0;
                            table.AddCell(new Phrase(id_cow.ToString(), fontParagraph));
                            for (int i = 0; i < apparatDataGridView.RowCount - 1; i++)
                            {
                                if (Convert.ToInt32(apparatDataGridView.Rows[i].Cells[2].Value) == id_cow && Convert.ToDateTime(apparatDataGridView.Rows[i].Cells[4].Value).Date == DateTime.Today)
                                {
                                    sum_udoy += Convert.ToInt32(apparatDataGridView.Rows[i].Cells[5].Value);
                                    count += 1;
                                }
                            }
                        table.AddCell(new Phrase((Math.Round(sum_udoy / count, 3)).ToString(), fontParagraph));
                        table.AddCell(new Phrase(sum_udoy.ToString(), fontParagraph));
                        id_cows[count_cows] = id_cow;
                        count_cows++;
                    }
                }
                //Добавляем таблицу в документ
                doc.Add(table);
                doc.Add(new Paragraph("Погрешность = 0.001", fontParagraph));
                //Закрываем документ
                doc.Close();
            }
        }

        private void MonthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Сохранение";
            saveFileDialog1.FileName = "";
            saveFileDialog1.DefaultExt = "*.pdf";
            saveFileDialog1.Filter = "Файлы pdf (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SaveFileName = saveFileDialog1.FileName;

                //Объект документа пдф
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                //Создаем объект записи пдф-документа в файл
                PdfWriter.GetInstance(doc, new FileStream(SaveFileName, FileMode.Create));

                //Открываем документ
                doc.Open();

                //Определение шрифта необходимо для сохранения кириллического текста
                //Иначе мы не увидим кириллический текст
                //Если мы работаем только с англоязычными текстами, то шрифт можно не указывать
                string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
                BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
                iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL); //регистрируем + можно задать параметры для него(17 - размер, последний параметр - стиль)
                                                                                                                          //Создаем объект таблицы и передаем в нее число столбцов таблицы из нашего датасета
                PdfPTable table = new PdfPTable(3);//MyDataSet.Tables[i].Columns.Count);
                                                   //Добавим в таблицу общий заголовок
                PdfPCell cell = new PdfPCell(new Phrase("Месячный средний удой"));
                cell.Colspan = 3;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы был как заголовок
                cell.Border = 0;
                table.AddCell(cell);
                //Сначала добавляем заголовки таблицы
                cell = new PdfPCell(new Phrase(new Phrase("Номер коровы", fontParagraph)));
                //Фоновый цвет (необязательно, просто сделаем по красивее)
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Средний удой за месяц", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Суммарный удой за месяц", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                int[] id_cows = new int[apparatDataGridView.RowCount];
                int count_cows = 0;
                //Добавляем все остальные ячейки
                for (int j = 0; j < apparatDataGridView.RowCount - 1; j++)
                {
                    if (Convert.ToDateTime(apparatDataGridView.Rows[j].Cells[4].Value).Date.Month == DateTime.Today.Month && Convert.ToDateTime(apparatDataGridView.Rows[j].Cells[4].Value).Date.Year == DateTime.Today.Year && !id_cows.Contains(Convert.ToInt32(apparatDataGridView.Rows[j].Cells[2].Value)))
                    {
                        int id_cow = Convert.ToInt32(apparatDataGridView.Rows[j].Cells[2].Value), count = 0;
                        double sum_udoy = 0;
                        table.AddCell(new Phrase(id_cow.ToString(), fontParagraph));
                        for (int i = 0; i < apparatDataGridView.RowCount - 1; i++)
                        {
                            if (Convert.ToInt32(apparatDataGridView.Rows[i].Cells[2].Value) == id_cow && Convert.ToDateTime(apparatDataGridView.Rows[j].Cells[4].Value).Date.Month == DateTime.Today.Month && Convert.ToDateTime(apparatDataGridView.Rows[j].Cells[4].Value).Date.Year == DateTime.Today.Year)
                            {
                                sum_udoy += Convert.ToInt32(apparatDataGridView.Rows[i].Cells[5].Value);
                                count += 1;
                            }
                        }
                        table.AddCell(new Phrase((Math.Round(sum_udoy / count, 3)).ToString(), fontParagraph));
                        table.AddCell(new Phrase(sum_udoy.ToString(), fontParagraph));
                        id_cows[count_cows] = id_cow;
                        count_cows++;
                    }
                }
                //Добавляем таблицу в документ
                doc.Add(table);
                doc.Add(new Paragraph("Погрешность = 0.001", fontParagraph));
                //Закрываем документ
                doc.Close();
            }
        }

        private void MilkOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Сохранение";
            saveFileDialog1.FileName = "";
            saveFileDialog1.DefaultExt = "*.pdf";
            saveFileDialog1.Filter = "Файлы pdf (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SaveFileName = saveFileDialog1.FileName;

                //Объект документа пдф
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                //Создаем объект записи пдф-документа в файл
                PdfWriter.GetInstance(doc, new FileStream(SaveFileName, FileMode.Create));

                //Открываем документ
                doc.Open();

                //Определение шрифта необходимо для сохранения кириллического текста
                //Иначе мы не увидим кириллический текст
                //Если мы работаем только с англоязычными текстами, то шрифт можно не указывать
                string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
                BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
                iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL); //регистрируем + можно задать параметры для него(17 - размер, последний параметр - стиль)
                                                                                                                          //Создаем объект таблицы и передаем в нее число столбцов таблицы из нашего датасета
                PdfPTable table = new PdfPTable(2);//MyDataSet.Tables[i].Columns.Count);
                                                   //Добавим в таблицу общий заголовок
                PdfPCell cell = new PdfPCell(new Phrase("Молокоотдача коров"));
                cell.Colspan = 2;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы был как заголовок
                cell.Border = 0;
                table.AddCell(cell);
                //Сначала добавляем заголовки таблицы
                cell = new PdfPCell(new Phrase(new Phrase("Номер коровы", fontParagraph)));
                //Фоновый цвет (необязательно, просто сделаем по красивее)
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Молокоотдача коровы(скорость кг/мин)", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                //Добавляем все остальные ячейки
                for (int j = 0; j < apparatDataGridView.RowCount - 1; j++)
                {
                        //for (int k = 0; k < 3; k++)
                        //{
                        table.AddCell(new Phrase(apparatDataGridView.Rows[j].Cells[2].Value.ToString(), fontParagraph));
                        table.AddCell(new Phrase(apparatDataGridView.Rows[j].Cells[6].Value.ToString(), fontParagraph));
                        //}
                    }
                //Добавляем таблицу в документ
                doc.Add(table);
                //Закрываем документ
                doc.Close();
            }
        }
    }
}
