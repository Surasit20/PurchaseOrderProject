namespace Frontend.Report
{
    partial class BillReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Json.UriJsonSource uriJsonSource1 = new DevExpress.DataAccess.Json.UriJsonSource();
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode1 = new DevExpress.DataAccess.Json.JsonSchemaNode("root", true);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode2 = new DevExpress.DataAccess.Json.JsonSchemaNode("data", true);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode3 = new DevExpress.DataAccess.Json.JsonSchemaNode("id", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode4 = new DevExpress.DataAccess.Json.JsonSchemaNode("purchaser", true, DevExpress.DataAccess.Json.JsonNodeType.Property);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode5 = new DevExpress.DataAccess.Json.JsonSchemaNode("orderDateNow", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<System.DateTime>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode6 = new DevExpress.DataAccess.Json.JsonSchemaNode("orderDate", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<System.DateTime>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode7 = new DevExpress.DataAccess.Json.JsonSchemaNode("totalPrice", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<double>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode8 = new DevExpress.DataAccess.Json.JsonSchemaNode("orderItems", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode9 = new DevExpress.DataAccess.Json.JsonSchemaNode("id", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode10 = new DevExpress.DataAccess.Json.JsonSchemaNode("no", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode11 = new DevExpress.DataAccess.Json.JsonSchemaNode("productId", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode12 = new DevExpress.DataAccess.Json.JsonSchemaNode("product", true);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode13 = new DevExpress.DataAccess.Json.JsonSchemaNode("id", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode14 = new DevExpress.DataAccess.Json.JsonSchemaNode("title", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode15 = new DevExpress.DataAccess.Json.JsonSchemaNode("description", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode16 = new DevExpress.DataAccess.Json.JsonSchemaNode("imageUrl", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode17 = new DevExpress.DataAccess.Json.JsonSchemaNode("price", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<double>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode18 = new DevExpress.DataAccess.Json.JsonSchemaNode("unit", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode19 = new DevExpress.DataAccess.Json.JsonSchemaNode("productTypeId", true, DevExpress.DataAccess.Json.JsonNodeType.Property);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode20 = new DevExpress.DataAccess.Json.JsonSchemaNode("orderId", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode21 = new DevExpress.DataAccess.Json.JsonSchemaNode("quantity", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode22 = new DevExpress.DataAccess.Json.JsonSchemaNode("price", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<double>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode23 = new DevExpress.DataAccess.Json.JsonSchemaNode("totalPrice", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<double>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode24 = new DevExpress.DataAccess.Json.JsonSchemaNode("supplierId", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode25 = new DevExpress.DataAccess.Json.JsonSchemaNode("supplier", true);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode26 = new DevExpress.DataAccess.Json.JsonSchemaNode("id", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode27 = new DevExpress.DataAccess.Json.JsonSchemaNode("name", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode28 = new DevExpress.DataAccess.Json.JsonSchemaNode("address", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode29 = new DevExpress.DataAccess.Json.JsonSchemaNode("postalCode", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode30 = new DevExpress.DataAccess.Json.JsonSchemaNode("taxID", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode31 = new DevExpress.DataAccess.Json.JsonSchemaNode("officeName", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode32 = new DevExpress.DataAccess.Json.JsonSchemaNode("orders", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode33 = new DevExpress.DataAccess.Json.JsonSchemaNode("discount", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<double>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode34 = new DevExpress.DataAccess.Json.JsonSchemaNode("status", true, DevExpress.DataAccess.Json.JsonNodeType.Property);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode35 = new DevExpress.DataAccess.Json.JsonSchemaNode("success", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<bool>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode36 = new DevExpress.DataAccess.Json.JsonSchemaNode("message", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillReport));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrPictureBox1});
            this.TopMargin.HeightF = 157.2917F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel11,
            this.xrLabel12,
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.HeightF = 396.625F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 37.08334F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.HeightF = 102.875F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader1,
            this.Detail1});
            this.DetailReport.DataMember = "data.orderItems";
            this.DetailReport.DataSource = this.jsonDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 95.91669F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(328.125F, 95.91669F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(650F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.Text = "Bill Order ID :[data.id]";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 28F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.Detail1.HeightF = 27.91659F;
            this.Detail1.Name = "Detail1";
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(19.99055F, 0F);
            this.table2.Name = "table2";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table2.SizeF = new System.Drawing.SizeF(583.2679F, 28F);
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell28,
            this.tableCell29,
            this.tableCell30,
            this.tableCell31,
            this.tableCell32,
            this.tableCell33,
            this.tableCell34,
            this.tableCell36,
            this.tableCell37,
            this.tableCell38});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 1D;
            // 
            // tableCell28
            // 
            this.tableCell28.Name = "tableCell28";
            this.tableCell28.StyleName = "DetailCaption2";
            this.tableCell28.StylePriority.UseTextAlignment = false;
            this.tableCell28.Text = "no";
            this.tableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell28.Weight = 0.035590653052696812D;
            // 
            // tableCell29
            // 
            this.tableCell29.Name = "tableCell29";
            this.tableCell29.StyleName = "DetailCaption2";
            this.tableCell29.StylePriority.UseTextAlignment = false;
            this.tableCell29.Text = "product Id";
            this.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell29.Weight = 0.088835842426006617D;
            // 
            // tableCell30
            // 
            this.tableCell30.Name = "tableCell30";
            this.tableCell30.StyleName = "DetailCaption2";
            this.tableCell30.StylePriority.UseTextAlignment = false;
            this.tableCell30.Text = "product id";
            this.tableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell30.Weight = 0.088835842426006617D;
            // 
            // tableCell31
            // 
            this.tableCell31.Name = "tableCell31";
            this.tableCell31.StyleName = "DetailCaption2";
            this.tableCell31.Text = "product title";
            this.tableCell31.Weight = 0.10174828162560096D;
            // 
            // tableCell32
            // 
            this.tableCell32.Name = "tableCell32";
            this.tableCell32.StyleName = "DetailCaption2";
            this.tableCell32.Text = "product description";
            this.tableCell32.Weight = 0.15419927743765025D;
            // 
            // tableCell33
            // 
            this.tableCell33.Name = "tableCell33";
            this.tableCell33.StyleName = "DetailCaption2";
            this.tableCell33.StylePriority.UseTextAlignment = false;
            this.tableCell33.Text = "product price";
            this.tableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell33.Weight = 0.11064020010141226D;
            // 
            // tableCell34
            // 
            this.tableCell34.Name = "tableCell34";
            this.tableCell34.StyleName = "DetailCaption2";
            this.tableCell34.Text = "product unit";
            this.tableCell34.Weight = 0.10254245464618389D;
            // 
            // tableCell36
            // 
            this.tableCell36.Name = "tableCell36";
            this.tableCell36.StyleName = "DetailCaption2";
            this.tableCell36.StylePriority.UseTextAlignment = false;
            this.tableCell36.Text = "quantity";
            this.tableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell36.Weight = 0.0743208723801833D;
            // 
            // tableCell37
            // 
            this.tableCell37.Name = "tableCell37";
            this.tableCell37.StyleName = "DetailCaption2";
            this.tableCell37.StylePriority.UseTextAlignment = false;
            this.tableCell37.Text = "price";
            this.tableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell37.Weight = 0.052559051513671878D;
            // 
            // tableCell38
            // 
            this.tableCell38.Name = "tableCell38";
            this.tableCell38.StyleName = "DetailCaption2";
            this.tableCell38.StylePriority.UseTextAlignment = false;
            this.tableCell38.Text = "total Price";
            this.tableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell38.Weight = 0.088062838040865385D;
            // 
            // table3
            // 
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(19.99055F, 0F);
            this.table3.Name = "table3";
            this.table3.OddStyleName = "DetailData3_Odd";
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow4});
            this.table3.SizeF = new System.Drawing.SizeF(583.2679F, 25F);
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell40,
            this.tableCell41,
            this.tableCell42,
            this.tableCell43,
            this.tableCell44,
            this.tableCell45,
            this.tableCell46,
            this.tableCell48,
            this.tableCell49,
            this.tableCell50});
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Weight = 11.5D;
            // 
            // tableCell40
            // 
            this.tableCell40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[no]")});
            this.tableCell40.Name = "tableCell40";
            this.tableCell40.StyleName = "DetailData2";
            this.tableCell40.StylePriority.UseTextAlignment = false;
            this.tableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell40.Weight = 0.035590653052696812D;
            // 
            // tableCell41
            // 
            this.tableCell41.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[productId]")});
            this.tableCell41.Name = "tableCell41";
            this.tableCell41.StyleName = "DetailData2";
            this.tableCell41.StylePriority.UseTextAlignment = false;
            this.tableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell41.Weight = 0.088835842426006617D;
            // 
            // tableCell42
            // 
            this.tableCell42.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[product.id]")});
            this.tableCell42.Name = "tableCell42";
            this.tableCell42.StyleName = "DetailData2";
            this.tableCell42.StylePriority.UseTextAlignment = false;
            this.tableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell42.Weight = 0.088835842426006617D;
            // 
            // tableCell43
            // 
            this.tableCell43.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[product.title]")});
            this.tableCell43.Name = "tableCell43";
            this.tableCell43.StyleName = "DetailData2";
            this.tableCell43.Weight = 0.10174828162560096D;
            // 
            // tableCell44
            // 
            this.tableCell44.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[product.description]")});
            this.tableCell44.Name = "tableCell44";
            this.tableCell44.StyleName = "DetailData2";
            this.tableCell44.Weight = 0.15419927743765025D;
            // 
            // tableCell45
            // 
            this.tableCell45.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[product.price]")});
            this.tableCell45.Name = "tableCell45";
            this.tableCell45.StyleName = "DetailData2";
            this.tableCell45.StylePriority.UseTextAlignment = false;
            this.tableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell45.Weight = 0.11064020010141226D;
            // 
            // tableCell46
            // 
            this.tableCell46.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[product.unit]")});
            this.tableCell46.Name = "tableCell46";
            this.tableCell46.StyleName = "DetailData2";
            this.tableCell46.Weight = 0.10254245464618389D;
            // 
            // tableCell48
            // 
            this.tableCell48.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[quantity]")});
            this.tableCell48.Name = "tableCell48";
            this.tableCell48.StyleName = "DetailData2";
            this.tableCell48.StylePriority.UseTextAlignment = false;
            this.tableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell48.Weight = 0.0743208723801833D;
            // 
            // tableCell49
            // 
            this.tableCell49.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[price]")});
            this.tableCell49.Name = "tableCell49";
            this.tableCell49.StyleName = "DetailData2";
            this.tableCell49.StylePriority.UseTextAlignment = false;
            this.tableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell49.Weight = 0.052559051513671878D;
            // 
            // tableCell50
            // 
            this.tableCell50.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[totalPrice]")});
            this.tableCell50.Name = "tableCell50";
            this.tableCell50.StyleName = "DetailData2";
            this.tableCell50.StylePriority.UseTextAlignment = false;
            this.tableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell50.Weight = 0.088062838040865385D;
            // 
            // jsonDataSource1
            // 
            uriJsonSource1.PathParameters.AddRange(new DevExpress.DataAccess.Json.PathParameter[] {
            new DevExpress.DataAccess.Json.PathParameter("PathParameter1", "1004")});
            uriJsonSource1.Uri = new System.Uri("https://localhost:7243/api/Order/order/", System.UriKind.Absolute);
            this.jsonDataSource1.JsonSource = uriJsonSource1;
            this.jsonDataSource1.Name = "jsonDataSource1";
            jsonSchemaNode12.Nodes.Add(jsonSchemaNode13);
            jsonSchemaNode12.Nodes.Add(jsonSchemaNode14);
            jsonSchemaNode12.Nodes.Add(jsonSchemaNode15);
            jsonSchemaNode12.Nodes.Add(jsonSchemaNode16);
            jsonSchemaNode12.Nodes.Add(jsonSchemaNode17);
            jsonSchemaNode12.Nodes.Add(jsonSchemaNode18);
            jsonSchemaNode12.Nodes.Add(jsonSchemaNode19);
            jsonSchemaNode8.Nodes.Add(jsonSchemaNode9);
            jsonSchemaNode8.Nodes.Add(jsonSchemaNode10);
            jsonSchemaNode8.Nodes.Add(jsonSchemaNode11);
            jsonSchemaNode8.Nodes.Add(jsonSchemaNode12);
            jsonSchemaNode8.Nodes.Add(jsonSchemaNode20);
            jsonSchemaNode8.Nodes.Add(jsonSchemaNode21);
            jsonSchemaNode8.Nodes.Add(jsonSchemaNode22);
            jsonSchemaNode8.Nodes.Add(jsonSchemaNode23);
            jsonSchemaNode25.Nodes.Add(jsonSchemaNode26);
            jsonSchemaNode25.Nodes.Add(jsonSchemaNode27);
            jsonSchemaNode25.Nodes.Add(jsonSchemaNode28);
            jsonSchemaNode25.Nodes.Add(jsonSchemaNode29);
            jsonSchemaNode25.Nodes.Add(jsonSchemaNode30);
            jsonSchemaNode25.Nodes.Add(jsonSchemaNode31);
            jsonSchemaNode25.Nodes.Add(jsonSchemaNode32);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode3);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode4);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode5);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode6);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode7);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode8);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode24);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode25);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode33);
            jsonSchemaNode2.Nodes.Add(jsonSchemaNode34);
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode2);
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode35);
            jsonSchemaNode1.Nodes.Add(jsonSchemaNode36);
            this.jsonDataSource1.Schema = jsonSchemaNode1;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailCaption2
            // 
            this.DetailCaption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.DetailCaption2.BorderColor = System.Drawing.Color.White;
            this.DetailCaption2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption2.BorderWidth = 2F;
            this.DetailCaption2.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DetailCaption2.ForeColor = System.Drawing.Color.White;
            this.DetailCaption2.Name = "DetailCaption2";
            this.DetailCaption2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData2
            // 
            this.DetailData2.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData2.BorderWidth = 2F;
            this.DetailData2.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData2.ForeColor = System.Drawing.Color.Black;
            this.DetailData2.Name = "DetailData2";
            this.DetailData2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(427.9955F, 10.00001F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(82.29166F, 23F);
            this.xrLabel1.Text = "เวลาที่ออกบิล";
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(427.9955F, 52.70834F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(82.29166F, 23F);
            this.xrLabel2.Text = "เวลาที่ให้บิล";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[data].[orderDateNow]")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(528.1758F, 10.00001F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[data].[orderDate]")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(528.1758F, 52.70834F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel5.Text = "ผู้ชื่อ:";
            // 
            // xrLabel6
            // 
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 52.70834F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel6.Text = "ผู้ขาย:";
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[data].[purchaser]")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(124.7475F, 52.70834F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel7.Text = "xrLabel7";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[data].[supplier].[name]")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(124.7475F, 10.00001F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel8.Text = "xrLabel8";
            // 
            // xrLabel10
            // 
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[data].[totalPrice]")});
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(329.1667F, 39.79168F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrLabel9
            // 
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(213.5647F, 39.79168F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel9.Text = "ราคารวม:";
            // 
            // xrLabel11
            // 
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(213.5647F, 0.08335114F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel11.Text = "ลดราคา:";
            // 
            // xrLabel12
            // 
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[data].[discount]*[data].[totalPrice]")});
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(329.1667F, 0.08335114F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel12.Text = "xrLabel12";
            // 
            // xrLabel13
            // 
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(442.7083F, 0.08335114F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel13.Text = "บาท";
            // 
            // xrLabel14
            // 
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(442.7083F, 39.79168F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel14.Text = "บาท";
            // 
            // xrLabel15
            // 
            this.xrLabel15.AutoWidth = true;
            this.xrLabel15.CanShrink = true;
            this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Arial", 67.04F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(19.99054F, 38.125F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(259.1532F, 109.1667F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "น้ำซ๊อป";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(279.1438F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(290.625F, 157.2917F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // BillReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.Detail,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.jsonDataSource1});
            this.DataSource = this.jsonDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 157.2917F, 396.625F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailCaption2,
            this.DetailData2,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell28;
        private DevExpress.XtraReports.UI.XRTableCell tableCell29;
        private DevExpress.XtraReports.UI.XRTableCell tableCell30;
        private DevExpress.XtraReports.UI.XRTableCell tableCell31;
        private DevExpress.XtraReports.UI.XRTableCell tableCell32;
        private DevExpress.XtraReports.UI.XRTableCell tableCell33;
        private DevExpress.XtraReports.UI.XRTableCell tableCell34;
        private DevExpress.XtraReports.UI.XRTableCell tableCell36;
        private DevExpress.XtraReports.UI.XRTableCell tableCell37;
        private DevExpress.XtraReports.UI.XRTableCell tableCell38;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell40;
        private DevExpress.XtraReports.UI.XRTableCell tableCell41;
        private DevExpress.XtraReports.UI.XRTableCell tableCell42;
        private DevExpress.XtraReports.UI.XRTableCell tableCell43;
        private DevExpress.XtraReports.UI.XRTableCell tableCell44;
        private DevExpress.XtraReports.UI.XRTableCell tableCell45;
        private DevExpress.XtraReports.UI.XRTableCell tableCell46;
        private DevExpress.XtraReports.UI.XRTableCell tableCell48;
        private DevExpress.XtraReports.UI.XRTableCell tableCell49;
        private DevExpress.XtraReports.UI.XRTableCell tableCell50;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption2;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData2;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
    }
}
