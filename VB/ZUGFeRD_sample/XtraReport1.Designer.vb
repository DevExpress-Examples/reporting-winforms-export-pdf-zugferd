Namespace ZUGFeRD_sample
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Dim xrWatermark1 As New DevExpress.XtraReports.UI.XRWatermark()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.cfDateTime = New DevExpress.XtraReports.UI.CalculatedField()
			Me.ApplicablePersent_num = New DevExpress.XtraReports.UI.CalculatedField()
			Me.sum = New DevExpress.XtraReports.UI.CalculatedField()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.Detail.HeightF = 25.00002F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable2
			' 
			Me.xrTable2.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00015F, 0F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F)
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(629.9999F, 25.00002F)
			Me.xrTable2.StylePriority.UseBorders = False
			Me.xrTable2.StylePriority.UsePadding = False
			Me.xrTable2.StylePriority.UseTextAlignment = False
			Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 1R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IncludedSupplyChainTradeLineItem_SpecifiedLineTradeDelivery].[SpecifiedLineTrade" & "Delivery_BilledQuantity].[BilledQuantity_Text]")})
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.StylePriority.UseTextAlignment = False
			Me.xrTableCell6.Text = "#"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell6.Weight = 0.28075373200988429R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IncludedSupplyChainTradeLineItem.IncludedSupplyChainTradeLineItem_SpecifiedTrade" & "Product.Name]")})
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.StylePriority.UseTextAlignment = False
			Me.xrTableCell7.Text = "Product"
			Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell7.Weight = 1.2192462679901157R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IncludedSupplyChainTradeLineItem_SpecifiedLineTradeSettlement.SpecifiedLineTrade" & "Settlement_ApplicableTradeTax.RateApplicablePercent]")})
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.StylePriority.UseTextAlignment = False
			Me.xrTableCell8.Text = "USt"
			Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell8.TextFormatString = "{0} %"
			Me.xrTableCell8.Weight = 0.5R
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.StylePriority.UseTextAlignment = False
			Me.xrTableCell9.Text = "[IncludedSupplyChainTradeLineItem_SpecifiedLineTradeAgreement.SpecifiedLineTradeA" & "greement_NetPriceProductTradePrice.ChargeAmount] €"
			Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell9.Weight = 0.5R
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", resources.GetString("xrTableCell10.ExpressionBindings"))})
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.StylePriority.UseTextAlignment = False
			Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell10.TextFormatString = "{0:€ 0.00}"
			Me.xrTableCell10.Weight = 0.5R
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1, Me.xrLabel9, Me.xrLabel7, Me.xrLabel8, Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
			Me.ReportHeader.HeightF = 269.7917F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrTable1
			' 
			Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 244.7917F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(629.9999F, 25.00002F)
			Me.xrTable1.StylePriority.UseBorders = False
			Me.xrTable1.StylePriority.UsePadding = False
			Me.xrTable1.StylePriority.UseTextAlignment = False
			Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell4, Me.xrTableCell2, Me.xrTableCell5, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.StylePriority.UseTextAlignment = False
			Me.xrTableCell1.Text = "#"
			Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell1.Weight = 0.28075373200988429R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.StylePriority.UseTextAlignment = False
			Me.xrTableCell4.Text = "Product"
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell4.Weight = 1.2192462679901157R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.StylePriority.UseTextAlignment = False
			Me.xrTableCell2.Text = "USt"
			Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell2.Weight = 0.5R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.StylePriority.UseTextAlignment = False
			Me.xrTableCell5.Text = "Einzelpreis"
			Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell5.Weight = 0.5R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.StylePriority.UseTextAlignment = False
			Me.xrTableCell3.Text = "Summe"
			Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCell3.Weight = 0.5R
			' 
			' xrLabel9
			' 
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 170.125F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(629.9999F, 33F)
			Me.xrLabel9.Text = "Rechnung # [ExchangedDocument.ID] vom [ExchangedDocument.ExchangedDocument_IssueD" & "ateTime.IssueDateTime_DateTimeString.cfDateTime!d]"
			' 
			' xrLabel7
			' 
			Me.xrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApplicableHeaderTradeAgreement.ApplicableHeaderTradeAgreement_SellerTradeParty.S" & "ellerTradeParty_PostalTradeAddress.PostcodeCode]")})
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(356.6667F, 93.70833F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel7.Text = "xrLabel3"
			' 
			' xrLabel8
			' 
			Me.xrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApplicableHeaderTradeAgreement.ApplicableHeaderTradeAgreement_SellerTradeParty.S" & "ellerTradeParty_PostalTradeAddress.CityName]")})
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(468.5417F, 93.70833F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(171.4584F, 23F)
			Me.xrLabel8.Text = "xrLabel4"
			' 
			' xrLabel6
			' 
			Me.xrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApplicableHeaderTradeAgreement.ApplicableHeaderTradeAgreement_SellerTradeParty.S" & "ellerTradeParty_PostalTradeAddress.LineOne]")})
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(357.9166F, 56.20832F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(282.0834F, 23F)
			Me.xrLabel6.Text = "xrLabel6"
			' 
			' xrLabel5
			' 
			Me.xrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApplicableHeaderTradeAgreement.ApplicableHeaderTradeAgreement_SellerTradeParty.N" & "ame]")})
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(357.9166F, 10.00001F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(282.0834F, 33.41667F)
			Me.xrLabel5.Text = "xrLabel5"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApplicableHeaderTradeAgreement.ApplicableHeaderTradeAgreement_BuyerTradeParty.Bu" & "yerTradeParty_PostalTradeAddress.CityName]")})
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(121.875F, 93.70833F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(171.4584F, 23F)
			Me.xrLabel4.Text = "xrLabel4"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApplicableHeaderTradeAgreement.ApplicableHeaderTradeAgreement_BuyerTradeParty.Bu" & "yerTradeParty_PostalTradeAddress.PostcodeCode]")})
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 93.70833F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApplicableHeaderTradeAgreement.ApplicableHeaderTradeAgreement_BuyerTradeParty.Bu" & "yerTradeParty_PostalTradeAddress.LineOne]")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 56.20832F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(283.3334F, 23F)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApplicableHeaderTradeAgreement.ApplicableHeaderTradeAgreement_BuyerTradeParty.Na" & "me]")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(283.3333F, 33.41667F)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' cfDateTime
			' 
			Me.cfDateTime.DataMember = "ExchangedDocument.ExchangedDocument_IssueDateTime.IssueDateTime_DateTimeString"
			Me.cfDateTime.Expression = resources.GetString("cfDateTime.Expression")
			Me.cfDateTime.Name = "cfDateTime"
			' 
			' ApplicablePersent_num
			' 
			Me.ApplicablePersent_num.Expression = "ToDouble([RateApplicablePercent])"
			Me.ApplicablePersent_num.Name = "ApplicablePersent_num"
			' 
			' sum
			' 
			Me.sum.DataMember = "SupplyChainTradeTransaction.SupplyChainTradeTransaction_IncludedSupplyChainTradeL" & "ineItem"
			Me.sum.Expression = resources.GetString("sum.Expression")
			Me.sum.Name = "sum"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.cfDateTime, Me.ApplicablePersent_num, Me.sum})
			Me.DataMember = "SupplyChainTradeTransaction.SupplyChainTradeTransaction_IncludedSupplyChainTradeL" & "ineItem"
			Me.Version = "24.2"
			xrWatermark1.Id = "Watermark1"
			Me.Watermarks.AddRange(New DevExpress.XtraPrinting.Drawing.Watermark() { xrWatermark1})
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private cfDateTime As DevExpress.XtraReports.UI.CalculatedField
		Private ApplicablePersent_num As DevExpress.XtraReports.UI.CalculatedField
		Private sum As DevExpress.XtraReports.UI.CalculatedField
	End Class
End Namespace
