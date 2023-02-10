using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace OPTYPE.HizliTeknoloji
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[ServiceContract(ConfigurationName="HizliTeknoloji.IHizliService")]
	public interface IHizliService
	{
		[OperationContract(Action="http://tempuri.org/IHizliService/CancelDocument", ReplyAction="http://tempuri.org/IHizliService/CancelDocumentResponse")]
		ResponseMessage CancelDocument([MessageParameter(Name="cancelDocument")] CancelDocumentInput cancelDocument1);

		[OperationContract(Action="http://tempuri.org/IHizliService/CancelDocument", ReplyAction="http://tempuri.org/IHizliService/CancelDocumentResponse")]
		Task<ResponseMessage> CancelDocumentAsync(CancelDocumentInput cancelDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/CancelEArsivInvoice", ReplyAction="http://tempuri.org/IHizliService/CancelEArsivInvoiceResponse")]
		ResponseMessage CancelEArsivInvoice(string Uuid, string CancelReason);

		[OperationContract(Action="http://tempuri.org/IHizliService/CancelEArsivInvoice", ReplyAction="http://tempuri.org/IHizliService/CancelEArsivInvoiceResponse")]
		Task<ResponseMessage> CancelEArsivInvoiceAsync(string Uuid, string CancelReason);

		[OperationContract(Action="http://tempuri.org/IHizliService/ControlDocumentXML", ReplyAction="http://tempuri.org/IHizliService/ControlDocumentXMLResponse")]
		ResponseMessage ControlDocumentXML(ControlDocument controlDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/ControlDocumentXML", ReplyAction="http://tempuri.org/IHizliService/ControlDocumentXMLResponse")]
		Task<ResponseMessage> ControlDocumentXMLAsync(ControlDocument controlDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetCustomerCreditCount", ReplyAction="http://tempuri.org/IHizliService/GetCustomerCreditCountResponse")]
		CreditInfo GetCustomerCreditCount(string vkn_tckn);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetCustomerCreditCount", ReplyAction="http://tempuri.org/IHizliService/GetCustomerCreditCountResponse")]
		Task<CreditInfo> GetCustomerCreditCountAsync(string vkn_tckn);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetDocumentFile", ReplyAction="http://tempuri.org/IHizliService/GetDocumentFileResponse")]
		DocumentContent GetDocumentFile(int AppType, string Uuid, string Tur, bool? IsDraft);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetDocumentFile", ReplyAction="http://tempuri.org/IHizliService/GetDocumentFileResponse")]
		Task<DocumentContent> GetDocumentFileAsync(int AppType, string Uuid, string Tur, bool? IsDraft);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetDocumentFileTransfer", ReplyAction="http://tempuri.org/IHizliService/GetDocumentFileTransferResponse")]
		DocumentContent GetDocumentFileTransfer(int AppType, string Uuid, string Tur);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetDocumentFileTransfer", ReplyAction="http://tempuri.org/IHizliService/GetDocumentFileTransferResponse")]
		Task<DocumentContent> GetDocumentFileTransferAsync(int AppType, string Uuid, string Tur);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetDocumentList", ReplyAction="http://tempuri.org/IHizliService/GetDocumentListResponse")]
		DocumentList GetDocumentList(int AppType, string DateType, DateTime StartDate, DateTime EndDate, bool IsNew, bool IsExport, bool? IsDraft, string TakenFromEntegrator);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetDocumentList", ReplyAction="http://tempuri.org/IHizliService/GetDocumentListResponse")]
		Task<DocumentList> GetDocumentListAsync(int AppType, string DateType, DateTime StartDate, DateTime EndDate, bool IsNew, bool IsExport, bool? IsDraft, string TakenFromEntegrator);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetDocumentListGUID", ReplyAction="http://tempuri.org/IHizliService/GetDocumentListGUIDResponse")]
		DocumentList GetDocumentListGUID(int AppType, string[] GUIDList);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetDocumentListGUID", ReplyAction="http://tempuri.org/IHizliService/GetDocumentListGUIDResponse")]
		Task<DocumentList> GetDocumentListGUIDAsync(int AppType, string[] GUIDList);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetDocumentListTransfer", ReplyAction="http://tempuri.org/IHizliService/GetDocumentListTransferResponse")]
		DocumentList GetDocumentListTransfer(int AppType, string DateType, DateTime StartDate, DateTime EndDate);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetDocumentListTransfer", ReplyAction="http://tempuri.org/IHizliService/GetDocumentListTransferResponse")]
		Task<DocumentList> GetDocumentListTransferAsync(int AppType, string DateType, DateTime StartDate, DateTime EndDate);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetGibUserAliasCreationTime", ReplyAction="http://tempuri.org/IHizliService/GetGibUserAliasCreationTimeResponse")]
		GibUserListAliasCreation GetGibUserAliasCreationTime(string Type, DateTime StartDate, DateTime EndDate);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetGibUserAliasCreationTime", ReplyAction="http://tempuri.org/IHizliService/GetGibUserAliasCreationTimeResponse")]
		Task<GibUserListAliasCreation> GetGibUserAliasCreationTimeAsync(string Type, DateTime StartDate, DateTime EndDate);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetGibUserAliasCreationTimeList", ReplyAction="http://tempuri.org/IHizliService/GetGibUserAliasCreationTimeListResponse")]
		GibUserListAliasCreationList GetGibUserAliasCreationTimeList(int AppType, string Type, DateTime StartDate, DateTime EndDate);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetGibUserAliasCreationTimeList", ReplyAction="http://tempuri.org/IHizliService/GetGibUserAliasCreationTimeListResponse")]
		Task<GibUserListAliasCreationList> GetGibUserAliasCreationTimeListAsync(int AppType, string Type, DateTime StartDate, DateTime EndDate);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetGibUserFile", ReplyAction="http://tempuri.org/IHizliService/GetGibUserFileResponse")]
		DocumentContent GetGibUserFile(int AppType, string Type);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetGibUserFile", ReplyAction="http://tempuri.org/IHizliService/GetGibUserFileResponse")]
		Task<DocumentContent> GetGibUserFileAsync(int AppType, string Type);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetGibUserList", ReplyAction="http://tempuri.org/IHizliService/GetGibUserListResponse")]
		GibUserList GetGibUserList(int AppType, string Type, string Identifier);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetGibUserList", ReplyAction="http://tempuri.org/IHizliService/GetGibUserListResponse")]
		Task<GibUserList> GetGibUserListAsync(int AppType, string Type, string Identifier);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetGibUserListUserXml", ReplyAction="http://tempuri.org/IHizliService/GetGibUserListUserXmlResponse")]
		GibUserListUserXml GetGibUserListUserXml(string Type, string Identifier);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetGibUserListUserXml", ReplyAction="http://tempuri.org/IHizliService/GetGibUserListUserXmlResponse")]
		Task<GibUserListUserXml> GetGibUserListUserXmlAsync(string Type, string Identifier);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetLastInvoiceIdAndDate", ReplyAction="http://tempuri.org/IHizliService/GetLastInvoiceIdAndDateResponse")]
		InvoiceIdAndDateModel GetLastInvoiceIdAndDate(int AppType, string Seri);

		[OperationContract(Action="http://tempuri.org/IHizliService/GetLastInvoiceIdAndDate", ReplyAction="http://tempuri.org/IHizliService/GetLastInvoiceIdAndDateResponse")]
		Task<InvoiceIdAndDateModel> GetLastInvoiceIdAndDateAsync(int AppType, string Seri);

		[OperationContract(Action="http://tempuri.org/IHizliService/KalanKontorSorgula", ReplyAction="http://tempuri.org/IHizliService/KalanKontorSorgulaResponse")]
		EntResponseUser KalanKontorSorgula(string vkn_tckn, BirimTuru birimTuru);

		[OperationContract(Action="http://tempuri.org/IHizliService/KalanKontorSorgula", ReplyAction="http://tempuri.org/IHizliService/KalanKontorSorgulaResponse")]
		Task<EntResponseUser> KalanKontorSorgulaAsync(string vkn_tckn, BirimTuru birimTuru);

		[OperationContract(Action="http://tempuri.org/IHizliService/KontorHareketleri", ReplyAction="http://tempuri.org/IHizliService/KontorHareketleriResponse")]
		KrediRaporOutput KontorHareketleri();

		[OperationContract(Action="http://tempuri.org/IHizliService/KontorHareketleri", ReplyAction="http://tempuri.org/IHizliService/KontorHareketleriResponse")]
		Task<KrediRaporOutput> KontorHareketleriAsync();

		[OperationContract(Action="http://tempuri.org/IHizliService/KontorYukle", ReplyAction="http://tempuri.org/IHizliService/KontorYukleResponse")]
		ResponseMessage KontorYukle(KontorYukleModel kontor);

		[OperationContract(Action="http://tempuri.org/IHizliService/KontorYukle", ReplyAction="http://tempuri.org/IHizliService/KontorYukleResponse")]
		Task<ResponseMessage> KontorYukleAsync(KontorYukleModel kontor);

		[OperationContract(Action="http://tempuri.org/IHizliService/MukellefBilgisiSorgulama", ReplyAction="http://tempuri.org/IHizliService/MukellefBilgisiSorgulamaResponse")]
		MukellefOutput MukellefBilgisiSorgulama(MukellefBilgisi mukellefBilgisi);

		[OperationContract(Action="http://tempuri.org/IHizliService/MukellefBilgisiSorgulama", ReplyAction="http://tempuri.org/IHizliService/MukellefBilgisiSorgulamaResponse")]
		Task<MukellefOutput> MukellefBilgisiSorgulamaAsync(MukellefBilgisi mukellefBilgisi);

		[OperationContract(Action="http://tempuri.org/IHizliService/MusteriAktifPasif", ReplyAction="http://tempuri.org/IHizliService/MusteriAktifPasifResponse")]
		ResponseMessage MusteriAktifPasif(MusteriAktifPasifModel input);

		[OperationContract(Action="http://tempuri.org/IHizliService/MusteriAktifPasif", ReplyAction="http://tempuri.org/IHizliService/MusteriAktifPasifResponse")]
		Task<ResponseMessage> MusteriAktifPasifAsync(MusteriAktifPasifModel input);

		[OperationContract(Action="http://tempuri.org/IHizliService/MusteriGetir", ReplyAction="http://tempuri.org/IHizliService/MusteriGetirResponse")]
		musteriOutput MusteriGetir(string vergikimlikno);

		[OperationContract(Action="http://tempuri.org/IHizliService/MusteriGetir", ReplyAction="http://tempuri.org/IHizliService/MusteriGetirResponse")]
		Task<musteriOutput> MusteriGetirAsync(string vergikimlikno);

		[OperationContract(Action="http://tempuri.org/IHizliService/MusteriOlustur", ReplyAction="http://tempuri.org/IHizliService/MusteriOlusturResponse")]
		musteriOutput MusteriOlustur(musteri hbtMusteri);

		[OperationContract(Action="http://tempuri.org/IHizliService/MusteriOlustur", ReplyAction="http://tempuri.org/IHizliService/MusteriOlusturResponse")]
		Task<musteriOutput> MusteriOlusturAsync(musteri hbtMusteri);

		[OperationContract(Action="http://tempuri.org/IHizliService/ObjectDocument", ReplyAction="http://tempuri.org/IHizliService/ObjectDocumentResponse")]
		ResponseMessage ObjectDocument([MessageParameter(Name="objectDocument")] ObjectDocumentInput objectDocument1);

		[OperationContract(Action="http://tempuri.org/IHizliService/ObjectDocument", ReplyAction="http://tempuri.org/IHizliService/ObjectDocumentResponse")]
		Task<ResponseMessage> ObjectDocumentAsync(ObjectDocumentInput objectDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/SendApplicationResponse", ReplyAction="http://tempuri.org/IHizliService/SendApplicationResponseResponse")]
		ResponseMessage SendApplicationResponse([MessageParameter(Name="sendApplicationResponse")] SendApplicationResponse sendApplicationResponse1);

		[OperationContract(Action="http://tempuri.org/IHizliService/SendApplicationResponse", ReplyAction="http://tempuri.org/IHizliService/SendApplicationResponseResponse")]
		Task<ResponseMessage> SendApplicationResponseAsync(SendApplicationResponse sendApplicationResponse);

		[OperationContract(Action="http://tempuri.org/IHizliService/SendApplicationResponseXml", ReplyAction="http://tempuri.org/IHizliService/SendApplicationResponseXmlResponse")]
		ResponseMessage SendApplicationResponseXml(InputDocument inputDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/SendApplicationResponseXml", ReplyAction="http://tempuri.org/IHizliService/SendApplicationResponseXmlResponse")]
		Task<ResponseMessage> SendApplicationResponseXmlAsync(InputDocument inputDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/SendDespatchAdviceModel", ReplyAction="http://tempuri.org/IHizliService/SendDespatchAdviceModelResponse")]
		OutputDespatchAdviceModel[] SendDespatchAdviceModel(InputDespatchAdviceModel[] inputDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/SendDespatchAdviceModel", ReplyAction="http://tempuri.org/IHizliService/SendDespatchAdviceModelResponse")]
		Task<OutputDespatchAdviceModel[]> SendDespatchAdviceModelAsync(InputDespatchAdviceModel[] inputDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/SendDocument", ReplyAction="http://tempuri.org/IHizliService/SendDocumentResponse")]
		ResponseMessage[] SendDocument(InputDocument[] inputDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/SendDocument", ReplyAction="http://tempuri.org/IHizliService/SendDocumentResponse")]
		Task<ResponseMessage[]> SendDocumentAsync(InputDocument[] inputDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/SendInvoiceModel", ReplyAction="http://tempuri.org/IHizliService/SendInvoiceModelResponse")]
		OutputInvoiceModel[] SendInvoiceModel(InputInvoiceModel[] inputDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/SendInvoiceModel", ReplyAction="http://tempuri.org/IHizliService/SendInvoiceModelResponse")]
		Task<OutputInvoiceModel[]> SendInvoiceModelAsync(InputInvoiceModel[] inputDocument);

		[OperationContract(Action="http://tempuri.org/IHizliService/SetDocumentFlag", ReplyAction="http://tempuri.org/IHizliService/SetDocumentFlagResponse")]
		ResponseMessage SetDocumentFlag(int AppType, string Uuid, string Flag_Name, int Flag_Value);

		[OperationContract(Action="http://tempuri.org/IHizliService/SetDocumentFlag", ReplyAction="http://tempuri.org/IHizliService/SetDocumentFlagResponse")]
		Task<ResponseMessage> SetDocumentFlagAsync(int AppType, string Uuid, string Flag_Name, int Flag_Value);

		[OperationContract(Action="http://tempuri.org/IHizliService/SetEmailSend", ReplyAction="http://tempuri.org/IHizliService/SetEmailSendResponse")]
		MailSendOutput SetEmailSend(MailSendInput mailSendInput);

		[OperationContract(Action="http://tempuri.org/IHizliService/SetEmailSend", ReplyAction="http://tempuri.org/IHizliService/SetEmailSendResponse")]
		Task<MailSendOutput> SetEmailSendAsync(MailSendInput mailSendInput);

		[OperationContract(Action="http://tempuri.org/IHizliService/SetTakenFromEntegrator", ReplyAction="http://tempuri.org/IHizliService/SetTakenFromEntegratorResponse")]
		ResponseMessage SetTakenFromEntegrator(TakenFromEntegratorModel takenFromEntegratorModel);

		[OperationContract(Action="http://tempuri.org/IHizliService/SetTakenFromEntegratorAlternative", ReplyAction="http://tempuri.org/IHizliService/SetTakenFromEntegratorAlternativeResponse")]
		ResponseMessage SetTakenFromEntegratorAlternative(int AppType, string[] GUIDList);

		[OperationContract(Action="http://tempuri.org/IHizliService/SetTakenFromEntegratorAlternative", ReplyAction="http://tempuri.org/IHizliService/SetTakenFromEntegratorAlternativeResponse")]
		Task<ResponseMessage> SetTakenFromEntegratorAlternativeAsync(int AppType, string[] GUIDList);

		[OperationContract(Action="http://tempuri.org/IHizliService/SetTakenFromEntegrator", ReplyAction="http://tempuri.org/IHizliService/SetTakenFromEntegratorResponse")]
		Task<ResponseMessage> SetTakenFromEntegratorAsync(TakenFromEntegratorModel takenFromEntegratorModel);

		[OperationContract(Action="http://tempuri.org/IHizliService/UploadDocumentTransfer", ReplyAction="http://tempuri.org/IHizliService/UploadDocumentTransferResponse")]
		ResponseMessage UploadDocumentTransfer(UploadDocumentTransferInput input);

		[OperationContract(Action="http://tempuri.org/IHizliService/UploadDocumentTransfer", ReplyAction="http://tempuri.org/IHizliService/UploadDocumentTransferResponse")]
		Task<ResponseMessage> UploadDocumentTransferAsync(UploadDocumentTransferInput input);
	}
}