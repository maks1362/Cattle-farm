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
using System.Diagnostics;

namespace Doyki
{
    public partial class UCTableReproductive : UserControl
    {
        public UCTableReproductive()
        {
            InitializeComponent();
            this.reproductiveTableAdapter.Fill(this.uchot_udoevDataSet2.Reproductive);
            reproductiveDataGridView.DoubleBuffered(true);
        }

        private void ReproductiveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reproductiveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet2);
        }


        private void SearchStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < reproductiveDataGridView.RowCount; i++)
            {
                reproductiveDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < reproductiveDataGridView.ColumnCount; j++)
                    if (reproductiveDataGridView.Rows[i].Cells[j].Value != null)
                        if (reproductiveDataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchStripTextBox.Text))
                        {
                            reproductiveDataGridView.Rows[i].Selected = true;
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

        private void ReproductivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Сохранение документа";
            saveFileDialog1.FileName = "Молокоотдача коров";
            saveFileDialog1.DefaultExt = "*.pdf";
            saveFileDialog1.Filter = "Файлы PDF (*.pdf)|*.pdf|Все файлы (*.*)|*.*";
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
                PdfPTable table = new PdfPTable(5);//MyDataSet.Tables[i].Columns.Count);
                                                   //Добавим в таблицу общий заголовок
                PdfPCell cell = new PdfPCell(new Phrase("Молокоотдача коров"));
                cell.Colspan = 5;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы был как заголовок
                cell.Border = 0;
                table.AddCell(cell);
                //Сначала добавляем заголовки таблицы
                cell = new PdfPCell(new Phrase(new Phrase("Номер коровы", fontParagraph)));
                //Фоновый цвет (необязательно, просто сделаем по красивее)
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Количество осеменения на одно плодотворное", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Продолжительность сервис периода", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Продолжительность сухостойного периода", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
                cell = new PdfPCell(new Phrase(new Phrase("Продолжительность межотельного периода", fontParagraph)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);

                //Добавляем все остальные ячейки
                for (int j = 0; j < reproductiveDataGridView.RowCount - 1; j++)
                {
                    table.AddCell(new Phrase(reproductiveDataGridView.Rows[j].Cells[1].Value.ToString(), fontParagraph));
                    table.AddCell(new Phrase(reproductiveDataGridView.Rows[j].Cells[2].Value.ToString(), fontParagraph));
                    table.AddCell(new Phrase(reproductiveDataGridView.Rows[j].Cells[7].Value.ToString(), fontParagraph));
                    table.AddCell(new Phrase(reproductiveDataGridView.Rows[j].Cells[8].Value.ToString(), fontParagraph));
                    if (reproductiveDataGridView.Rows[j].Cells[5].Value != null && reproductiveDataGridView.Rows[j].Cells[4].Value != null && reproductiveDataGridView.Rows[j].Cells[5].Value.ToString().Length > 4 && reproductiveDataGridView.Rows[j].Cells[4].Value.ToString().Length > 4)
                    {
                        TimeSpan day = Convert.ToDateTime(reproductiveDataGridView.Rows[j].Cells[4].Value) - Convert.ToDateTime(reproductiveDataGridView.Rows[j].Cells[5].Value);
                        table.AddCell(new Phrase(day.Days.ToString(), fontParagraph));
                    }
                    else
                    {
                        table.AddCell(new Phrase("", fontParagraph));
                    }
                }
                //Добавляем таблицу в документ
                doc.Add(table);
                //Закрываем документ
                doc.Close();
                Process.Start(saveFileDialog1.FileName);
            }
        }
    }
}
