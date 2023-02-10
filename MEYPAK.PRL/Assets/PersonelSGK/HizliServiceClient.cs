using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Binding = System.ServiceModel.Channels.Binding;

namespace OPTYPE.HizliTeknoloji
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class HizliServiceClient : ClientBase<IHizliService>, IHizliService
	{
		public HizliServiceClient()
		{
		}

		public HizliServiceClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public HizliServiceClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public HizliServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public HizliServiceClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		public ResponseMessage CancelDocument(CancelDocumentInput cancelDocument1)
		{
			return base.Channel.CancelDocument(cancelDocument1);
		}

		public Task<ResponseMessage> CancelDocumentAsync(CancelDocumentInput cancelDocument)
		{
			return base.Channel.CancelDocumentAsync(cancelDocument);
		}

		public ResponseMessage CancelEArsivInvoice(string Uuid, string CancelReason)
		{
			return base.Channel.CancelEArsivInvoice(Uuid, CancelReason);
		}

		public Task<ResponseMessage> CancelEArsivInvoiceAsync(string Uuid, string CancelReason)
		{
			return base.Channel.CancelEArsivInvoiceAsync(Uuid, CancelReason);
		}

		public ResponseMessage ControlDocumentXML(ControlDocument controlDocument)
		{
			return base.Channel.ControlDocumentXML(controlDocument);
		}

		public Task<ResponseMessage> ControlDocumentXMLAsync(ControlDocument controlDocument)
		{
			return base.Channel.ControlDocumentXMLAsync(controlDocument);
		}

		public CreditInfo GetCustomerCreditCount(string vkn_tckn)
		{
			return base.Channel.GetCustomerCreditCount(vkn_tckn);
		}

		public Task<CreditInfo> GetCustomerCreditCountAsync(string vkn_tckn)
		{
			return base.Channel.GetCustomerCreditCountAsync(vkn_tckn);
		}

		public DocumentContent GetDocumentFile(int AppType, string Uuid, string Tur, bool? IsDraft)
		{
			return base.Channel.GetDocumentFile(AppType, Uuid, Tur, IsDraft);
		}

		public Task<DocumentContent> GetDocumentFileAsync(int AppType, string Uuid, string Tur, bool? IsDraft)
		{
			return base.Channel.GetDocumentFileAsync(AppType, Uuid, Tur, IsDraft);
		}

		public DocumentContent GetDocumentFileTransfer(int AppType, string Uuid, string Tur)
		{
			return base.Channel.GetDocumentFileTransfer(AppType, Uuid, Tur);
		}

		public Task<DocumentContent> GetDocumentFileTransferAsync(int AppType, string Uuid, string Tur)
		{
			return base.Channel.GetDocumentFileTransferAsync(AppType, Uuid, Tur);
		}

		public DocumentList GetDocumentList(int AppType, string DateType, DateTime StartDate, DateTime EndDate, bool IsNew, bool IsExport, bool? IsDraft, string TakenFromEntegrator)
		{
			DocumentList documentList = base.Channel.GetDocumentList(AppType, DateType, StartDate, EndDate, IsNew, IsExport, IsDraft, TakenFromEntegrator);
			return documentList;
		}

		public Task<DocumentList> GetDocumentListAsync(int AppType, string DateType, DateTime StartDate, DateTime EndDate, bool IsNew, bool IsExport, bool? IsDraft, string TakenFromEntegrator)
		{
			Task<DocumentList> documentListAsync = base.Channel.GetDocumentListAsync(AppType, DateType, StartDate, EndDate, IsNew, IsExport, IsDraft, TakenFromEntegrator);
			return documentListAsync;
		}

		public DocumentList GetDocumentListGUID(int AppType, string[] GUIDList)
		{
			return base.Channel.GetDocumentListGUID(AppType, GUIDList);
		}

		public Task<DocumentList> GetDocumentListGUIDAsync(int AppType, string[] GUIDList)
		{
			return base.Channel.GetDocumentListGUIDAsync(AppType, GUIDList);
		}

		public DocumentList GetDocumentListTransfer(int AppType, string DateType, DateTime StartDate, DateTime EndDate)
		{
			return base.Channel.GetDocumentListTransfer(AppType, DateType, StartDate, EndDate);
		}

		public Task<DocumentList> GetDocumentListTransferAsync(int AppType, string DateType, DateTime StartDate, DateTime EndDate)
		{
			return base.Channel.GetDocumentListTransferAsync(AppType, DateType, StartDate, EndDate);
		}

		public GibUserListAliasCreation GetGibUserAliasCreationTime(string Type, DateTime StartDate, DateTime EndDate)
		{
			return base.Channel.GetGibUserAliasCreationTime(Type, StartDate, EndDate);
		}

		public Task<GibUserListAliasCreation> GetGibUserAliasCreationTimeAsync(string Type, DateTime StartDate, DateTime EndDate)
		{
			return base.Channel.GetGibUserAliasCreationTimeAsync(Type, StartDate, EndDate);
		}

		public GibUserListAliasCreationList GetGibUserAliasCreationTimeList(int AppType, string Type, DateTime StartDate, DateTime EndDate)
		{
			return base.Channel.GetGibUserAliasCreationTimeList(AppType, Type, StartDate, EndDate);
		}

		public Task<GibUserListAliasCreationList> GetGibUserAliasCreationTimeListAsync(int AppType, string Type, DateTime StartDate, DateTime EndDate)
		{
			return base.Channel.GetGibUserAliasCreationTimeListAsync(AppType, Type, StartDate, EndDate);
		}

		public DocumentContent GetGibUserFile(int AppType, string Type)
		{
			return base.Channel.GetGibUserFile(AppType, Type);
		}

		public Task<DocumentContent> GetGibUserFileAsync(int AppType, string Type)
		{
			return base.Channel.GetGibUserFileAsync(AppType, Type);
		}

		public GibUserList GetGibUserList(int AppType, string Type, string Identifier)
		{
			return base.Channel.GetGibUserList(AppType, Type, Identifier);
		}

		public Task<GibUserList> GetGibUserListAsync(int AppType, string Type, string Identifier)
		{
			return base.Channel.GetGibUserListAsync(AppType, Type, Identifier);
		}

		public GibUserListUserXml GetGibUserListUserXml(string Type, string Identifier)
		{
			return base.Channel.GetGibUserListUserXml(Type, Identifier);
		}

		public Task<GibUserListUserXml> GetGibUserListUserXmlAsync(string Type, string Identifier)
		{
			return base.Channel.GetGibUserListUserXmlAsync(Type, Identifier);
		}

		public InvoiceIdAndDateModel GetLastInvoiceIdAndDate(int AppType, string Seri)
		{
			return base.Channel.GetLastInvoiceIdAndDate(AppType, Seri);
		}

		public Task<InvoiceIdAndDateModel> GetLastInvoiceIdAndDateAsync(int AppType, string Seri)
		{
			return base.Channel.GetLastInvoiceIdAndDateAsync(AppType, Seri);
		}

		public EntResponseUser KalanKontorSorgula(string vkn_tckn, BirimTuru birimTuru)
		{
			return base.Channel.KalanKontorSorgula(vkn_tckn, birimTuru);
		}

		public Task<EntResponseUser> KalanKontorSorgulaAsync(string vkn_tckn, BirimTuru birimTuru)
		{
			return base.Channel.KalanKontorSorgulaAsync(vkn_tckn, birimTuru);
		}

		public KrediRaporOutput KontorHareketleri()
		{
			return base.Channel.KontorHareketleri();
		}

		public Task<KrediRaporOutput> KontorHareketleriAsync()
		{
			return base.Channel.KontorHareketleriAsync();
		}

		public ResponseMessage KontorYukle(KontorYukleModel kontor)
		{
			return base.Channel.KontorYukle(kontor);
		}

		public Task<ResponseMessage> KontorYukleAsync(KontorYukleModel kontor)
		{
			return base.Channel.KontorYukleAsync(kontor);
		}

		public MukellefOutput MukellefBilgisiSorgulama(MukellefBilgisi mukellefBilgisi)
		{
			return base.Channel.MukellefBilgisiSorgulama(mukellefBilgisi);
		}

		public Task<MukellefOutput> MukellefBilgisiSorgulamaAsync(MukellefBilgisi mukellefBilgisi)
		{
			return base.Channel.MukellefBilgisiSorgulamaAsync(mukellefBilgisi);
		}

		public ResponseMessage MusteriAktifPasif(MusteriAktifPasifModel input)
		{
			return base.Channel.MusteriAktifPasif(input);
		}

		public Task<ResponseMessage> MusteriAktifPasifAsync(MusteriAktifPasifModel input)
		{
			return base.Channel.MusteriAktifPasifAsync(input);
		}

		public musteriOutput MusteriGetir(string vergikimlikno)
		{
			return base.Channel.MusteriGetir(vergikimlikno);
		}

		public Task<musteriOutput> MusteriGetirAsync(string vergikimlikno)
		{
			return base.Channel.MusteriGetirAsync(vergikimlikno);
		}

		public musteriOutput MusteriOlustur(musteri hbtMusteri)
		{
			return base.Channel.MusteriOlustur(hbtMusteri);
		}

		public Task<musteriOutput> MusteriOlusturAsync(musteri hbtMusteri)
		{
			return base.Channel.MusteriOlusturAsync(hbtMusteri);
		}

		public ResponseMessage ObjectDocument(ObjectDocumentInput objectDocument1)
		{
			return base.Channel.ObjectDocument(objectDocument1);
		}

		public Task<ResponseMessage> ObjectDocumentAsync(ObjectDocumentInput objectDocument)
		{
			return base.Channel.ObjectDocumentAsync(objectDocument);
		}

		public ResponseMessage SendApplicationResponse(SendApplicationResponse sendApplicationResponse1)
		{
			return base.Channel.SendApplicationResponse(sendApplicationResponse1);
		}

		public Task<ResponseMessage> SendApplicationResponseAsync(SendApplicationResponse sendApplicationResponse)
		{
			return base.Channel.SendApplicationResponseAsync(sendApplicationResponse);
		}

		public ResponseMessage SendApplicationResponseXml(InputDocument inputDocument)
		{
			return base.Channel.SendApplicationResponseXml(inputDocument);
		}

		public Task<ResponseMessage> SendApplicationResponseXmlAsync(InputDocument inputDocument)
		{
			return base.Channel.SendApplicationResponseXmlAsync(inputDocument);
		}

		public OutputDespatchAdviceModel[] SendDespatchAdviceModel(InputDespatchAdviceModel[] inputDocument)
		{
			return base.Channel.SendDespatchAdviceModel(inputDocument);
		}

		public Task<OutputDespatchAdviceModel[]> SendDespatchAdviceModelAsync(InputDespatchAdviceModel[] inputDocument)
		{
			return base.Channel.SendDespatchAdviceModelAsync(inputDocument);
		}

		public ResponseMessage[] SendDocument(InputDocument[] inputDocument)
		{
			return base.Channel.SendDocument(inputDocument);
		}

		public Task<ResponseMessage[]> SendDocumentAsync(InputDocument[] inputDocument)
		{
			return base.Channel.SendDocumentAsync(inputDocument);
		}

		public OutputInvoiceModel[] SendInvoiceModel(InputInvoiceModel[] inputDocument)
		{
			return base.Channel.SendInvoiceModel(inputDocument);
		}

		public Task<OutputInvoiceModel[]> SendInvoiceModelAsync(InputInvoiceModel[] inputDocument)
		{
			return base.Channel.SendInvoiceModelAsync(inputDocument);
		}

		public ResponseMessage SetDocumentFlag(int AppType, string Uuid, string Flag_Name, int Flag_Value)
		{
			return base.Channel.SetDocumentFlag(AppType, Uuid, Flag_Name, Flag_Value);
		}

		public Task<ResponseMessage> SetDocumentFlagAsync(int AppType, string Uuid, string Flag_Name, int Flag_Value)
		{
			return base.Channel.SetDocumentFlagAsync(AppType, Uuid, Flag_Name, Flag_Value);
		}

		public MailSendOutput SetEmailSend(MailSendInput mailSendInput)
		{
			return base.Channel.SetEmailSend(mailSendInput);
		}

		public Task<MailSendOutput> SetEmailSendAsync(MailSendInput mailSendInput)
		{
			return base.Channel.SetEmailSendAsync(mailSendInput);
		}

		public ResponseMessage SetTakenFromEntegrator(TakenFromEntegratorModel takenFromEntegratorModel)
		{
			return base.Channel.SetTakenFromEntegrator(takenFromEntegratorModel);
		}

		public ResponseMessage SetTakenFromEntegratorAlternative(int AppType, string[] GUIDList)
		{
			return base.Channel.SetTakenFromEntegratorAlternative(AppType, GUIDList);
		}

		public Task<ResponseMessage> SetTakenFromEntegratorAlternativeAsync(int AppType, string[] GUIDList)
		{
			return base.Channel.SetTakenFromEntegratorAlternativeAsync(AppType, GUIDList);
		}

		public Task<ResponseMessage> SetTakenFromEntegratorAsync(TakenFromEntegratorModel takenFromEntegratorModel)
		{
			return base.Channel.SetTakenFromEntegratorAsync(takenFromEntegratorModel);
		}

		public ResponseMessage UploadDocumentTransfer(UploadDocumentTransferInput input)
		{
			return base.Channel.UploadDocumentTransfer(input);
		}

		public Task<ResponseMessage> UploadDocumentTransferAsync(UploadDocumentTransferInput input)
		{
			return base.Channel.UploadDocumentTransferAsync(input);
		}
	}
}