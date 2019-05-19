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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Doyki
{
    public partial class UCTableCattle : UserControl
    {
        public UCTableCattle()
        {
            InitializeComponent();
        }

        private void CattleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cattleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uchot_udoevDataSet1);
        }

        private void AverageYieldToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Объект документа пдф
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            //Создаем объект записи пдф-документа в файл
            PdfWriter.GetInstance(doc, new FileStream("pdfTables.pdf", FileMode.Create));

            //Открываем документ
            doc.Open();

            //Определение шрифта необходимо для сохранения кириллического текста
            //Иначе мы не увидим кириллический текст
            //Если мы работаем только с англоязычными текстами, то шрифт можно не указывать
            string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
            BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
            iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL); //регистрируем + можно задать параметры для него(17 - размер, последний параметр - стиль)
            //Создаем объект таблицы и передаем в нее число столбцов таблицы из нашего датасета
            PdfPTable table = new PdfPTable(cattleDataGridView.ColumnCount);//MyDataSet.Tables[i].Columns.Count);
            //Добавим в таблицу общий заголовок
            PdfPCell cell = new PdfPCell(new Phrase("Отчёт такой-то"));
            cell.Colspan = cattleDataGridView.ColumnCount;
            cell.HorizontalAlignment = 1;
            //Убираем границу первой ячейки, чтобы был как заголовок
            cell.Border = 0;
            table.AddCell(cell);
            //Сначала добавляем заголовки таблицы
            for (int j = 0; j < cattleDataGridView.ColumnCount; j++)
            {
                cell = new PdfPCell(new Phrase(new Phrase(cattleDataGridView.Columns[j].HeaderText, fontParagraph)));
                //Фоновый цвет (необязательно, просто сделаем по красивее)
                cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
            }
            //Добавляем все остальные ячейки
            for (int j = 0; j < cattleDataGridView.RowCount-1; j++)
            {
                for (int k = 0; k < cattleDataGridView.ColumnCount; k++)
                {
                        table.AddCell(new Phrase(cattleDataGridView.Rows[j].Cells[k].Value.ToString(), fontParagraph));
                }
            }
            //Добавляем таблицу в документ
            doc.Add(table);
            //Закрываем документ
            doc.Close();

        }
    }
}
