using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.DataAccess;
using DevExpress.DataAccess.Json;
namespace Frontend.Report
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            // Create a new JSON source.
            var jsonSource = new UriJsonSource()
            {
                Uri = new Uri(@"https://localhost:44367/api/values")
            };
             // Create the "date" and "id" path parameters that are appended to the JSON URI: https://localhost:44367/api/values/date/2020-01-15/id/123/.
                    jsonSource.PathParameters.AddRange(new[] {
                new PathParameter("date", typeof(String), String.Format("{0:yyyy-MM-dd}", DateTime.Today)),
                // "ID" is a report parameter whose value is used for the "id" path parameter.
                new PathParameter("id", typeof(Expression), new Expression("?ID"))
            });
            // Assign the JSON source to the data source.
            var datasource = new JsonDataSource()
            {
                JsonSource = jsonSource
            };


            InitializeComponent();
        }


    }
}
