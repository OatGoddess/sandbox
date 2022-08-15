using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

public class HelloQuestPDFModule : IModule
{
	public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
	{
		endpoints.MapGet("/HelloQuest", () =>
		{
			var document = Document.Create(container =>
			{
				container.Page(page =>
				{
					page.Size(PageSizes.A4);
					page.Margin(2, Unit.Centimetre);
					page.PageColor(Colors.White);
					page.DefaultTextStyle(x => x.FontSize(20));

					page.Header()
						.Text("Hello PDF!")
						.SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

					page.Content()
						.PaddingVertical(1, Unit.Centimetre)
						.Column(x =>
						{
							x.Spacing(20);

							x.Item().Text(Placeholders.LoremIpsum());
							x.Item().Image(Placeholders.Image(200, 100));
						});

					page.Footer()
						.AlignCenter()
						.Text(x =>
						{
							x.Span("Page ");
							x.CurrentPageNumber();
						});
				});
			});

			/*uncomment this to use the Quest Previewer*/
			//document.ShowInPreviewer();
			
			var stream = new MemoryStream(document.GeneratePdf());

			return Results.File(stream, "applicaiton/pdf", "hello.pdf");
		});

		endpoints.MapGet("/QuestInvoice", () =>
		{
			var fileName = "invoice.pdf";

			var model = InvoiceDocumentDataSource.GetInvoiceDetails();
			var document = new InvoiceDocument(model);

			var stream = new MemoryStream(document.GeneratePdf());

			return Results.File(stream, "applicaiton/pdf", fileName);
		});
		return endpoints;
	}
}