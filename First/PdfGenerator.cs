using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

public class PdfGenerator
{
    public static void GenerateInvoice(string guestID, string guestName, string roomNo, string roomType, string payment, string receptionist)
    {
        string folderPath = @"C:\Users\User\Downloads\Hotel Management System\PDF files";
        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);

        string filePath = Path.Combine(folderPath, $"Invoice_{guestID}_{guestName}_{DateTime.Now:yyyyMMdd_HHmm}.pdf");

        Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
        PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
        doc.Open();

        var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
        var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
        var smallFont = FontFactory.GetFont(FontFactory.HELVETICA, 7);

        doc.Add(new Paragraph("Checkin Invoice", titleFont) { Alignment = Element.ALIGN_CENTER });
        doc.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------"));
        doc.Add(new Paragraph("\nGuest ID: " + guestID, normalFont));
        doc.Add(new Paragraph("Guest Name: " + guestName, normalFont));
        doc.Add(new Paragraph("Room No: " + roomNo, normalFont));
        doc.Add(new Paragraph("Room Type: " + roomType, normalFont));
        doc.Add(new Paragraph("Payment: " + payment, normalFont));
        doc.Add(new Paragraph("Checkin Date: " + DateTime.Now.ToShortDateString(), normalFont));
        doc.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------"));
        doc.Add(new Paragraph("\nPrinted by - " + receptionist, smallFont));
        doc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString(), smallFont));
        doc.Add(new Paragraph("\nThank you for staying with us!", normalFont) { Alignment = Element.ALIGN_CENTER });

        doc.Close();

        MessageBox.Show("Invoice generated at:\n" + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        System.Diagnostics.Process.Start(filePath);
    }

    public static void GenerateGuestReport(DataGridView dgv)
    {
        if (dgv.Rows.Count == 0)
        {
            MessageBox.Show("No data to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string folderPath = @"C:\Users\User\Downloads\Hotel Management System\PDF files";
        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);

        string filePath = Path.Combine(folderPath, $"GuestReport_{DateTime.Now:yyyyMMdd_HHmm}.pdf");

        Document doc = new Document(PageSize.A4, 20, 20, 20, 20);
        PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
        doc.Open();

        var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
        var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

        doc.Add(new Paragraph("Guest Report", titleFont) { Alignment = Element.ALIGN_CENTER });
        doc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString(), normalFont));
        doc.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------"));

        // Create PDF table
        PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
        pdfTable.WidthPercentage = 100;

        // Add headers
        foreach (DataGridViewColumn column in dgv.Columns)
        {
            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, normalFont));
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            pdfTable.AddCell(cell);
        }

        // Add rows
        foreach (DataGridViewRow row in dgv.Rows)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                pdfTable.AddCell(new Phrase(cell.Value?.ToString() ?? "", normalFont));
            }
        }

        doc.Add(pdfTable);
        doc.Close();

        MessageBox.Show("Guest Report PDF generated at:\n" + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        System.Diagnostics.Process.Start(filePath);
    }

}
