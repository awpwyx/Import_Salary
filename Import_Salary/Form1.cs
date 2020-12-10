using Kingdee.BOS.WebApi.Client;
using Newtonsoft.Json.Linq;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Import_Salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileStream fs = null;
        SJX_Select _BLL_POP_Select = new SJX_Select();
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            //#region
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Multiselect = false;//该值确定是否可以选择多个文件
            //dialog.Title = "请选择电子文档excel";
            //dialog.Filter = "所有文件(*.xlsx)|*.xlsx";
            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    MessageBox.Show(dialog.FileName);
            //    try
            //    {
            //        using (fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
            //        {
            //            IWorkbook workbook = new XSSFWorkbook(fs);

            //            if (workbook != null)
            //            {
            //                ISheet sheet = workbook.GetSheet("劳动用工工资");//读取第一个sheet

            //                int rowCount = sheet.LastRowNum;//总行数
            //                for(int i=2;i< rowCount&&i<46; i++)
            //                {
            //                    entry = "";
            //                    string note = "计提"+ sheet.GetRow(i).GetCell(6).StringCellValue+"工资";
            //                    string accontCode = "5001.2";
            //                    string debit = sheet.GetRow(i).GetCell(27).NumericCellValue.ToString();
            //                    string credit = "0";
            //                    inentry(1, note, accontCode, debit, credit);


            //                    note = "计提" + sheet.GetRow(i).GetCell(6).StringCellValue + "工资";
            //                    accontCode = "2201.01";
            //                    debit = "0";
            //                    credit= sheet.GetRow(i).GetCell(27).NumericCellValue.ToString();
            //                    inentry(2, note, accontCode, debit, credit);

            //                    note = "代扣" + sheet.GetRow(i).GetCell(6).StringCellValue + "工资";
            //                    accontCode = "2201.01";
            //                    debit = (sheet.GetRow(i).GetCell(28).NumericCellValue + sheet.GetRow(i).GetCell(29).NumericCellValue + sheet.GetRow(i).GetCell(30).NumericCellValue + sheet.GetRow(i).GetCell(31).NumericCellValue + sheet.GetRow(i).GetCell(34).NumericCellValue).ToString(); ;
            //                    credit = "0";
            //                    inentry(3, note, accontCode, debit, credit);

            //                    note = "代扣" + sheet.GetRow(i).GetCell(6).StringCellValue + "公积金";
            //                    accontCode = "2305.04";
            //                    debit = "0";
            //                    credit = sheet.GetRow(i).GetCell(31).NumericCellValue.ToString();
            //                    inentry(4, note, accontCode, debit, credit);

            //                    note = "代扣" + sheet.GetRow(i).GetCell(6).StringCellValue + "社会保险";
            //                    accontCode = "2305.03";
            //                    debit = "0";
            //                    credit =(sheet.GetRow(i).GetCell(28).NumericCellValue+ sheet.GetRow(i).GetCell(29).NumericCellValue+ sheet.GetRow(i).GetCell(30).NumericCellValue).ToString();
            //                    inentry(5, note, accontCode, debit, credit);


            //                    note = "代扣" + sheet.GetRow(i).GetCell(6).StringCellValue + "个税";
            //                    accontCode = "2101.11";
            //                    debit = "0";
            //                    credit = sheet.GetRow(i).GetCell(34).NumericCellValue.ToString() ;
            //                    inentry(6, note, accontCode, debit, credit);

            //                    note = "计提" + sheet.GetRow(i).GetCell(6).StringCellValue + "公积金单位承担部分";
            //                    accontCode = "5001.02";
            //                    debit = "0";
            //                    credit = sheet.GetRow(i).GetCell(43).NumericCellValue.ToString();
            //                    inentry(7, note, accontCode, debit, credit);


            //                    note = "计提" + sheet.GetRow(i).GetCell(6).StringCellValue + "公积金单位承担部分";
            //                    accontCode = "2201.04";
            //                    debit = sheet.GetRow(i).GetCell(43).NumericCellValue.ToString(); ;
            //                    credit = "0";
            //                    inentry(8, note, accontCode, debit, credit);


            //                    note = "计提" + sheet.GetRow(i).GetCell(6).StringCellValue + "社保单位承担部分";
            //                    accontCode = "5001.02";
            //                    debit = "0";
            //                    credit = sheet.GetRow(i).GetCell(39).NumericCellValue.ToString();
            //                    inentry(9, note, accontCode, debit, credit);

            //                    note = "计提" + sheet.GetRow(i).GetCell(6).StringCellValue + "社保单位承担部分";
            //                    accontCode = "2201.03";
            //                    debit = sheet.GetRow(i).GetCell(39).NumericCellValue.ToString();
            //                    credit = "0";
            //                    inentry(10, note, accontCode, debit, credit);

            //                    note = "计提" + sheet.GetRow(i).GetCell(6).StringCellValue + "工资";
            //                    accontCode = "1215.03.01";
            //                    debit = (sheet.GetRow(i).GetCell(28).NumericCellValue + sheet.GetRow(i).GetCell(29).NumericCellValue + sheet.GetRow(i).GetCell(30).NumericCellValue + sheet.GetRow(i).GetCell(31).NumericCellValue + sheet.GetRow(i).GetCell(34).NumericCellValue + sheet.GetRow(i).GetCell(39).NumericCellValue + sheet.GetRow(i).GetCell(43).NumericCellValue + sheet.GetRow(i).GetCell(27).NumericCellValue).ToString();
            //                    credit = "0";
            //                    inentry(11, note, accontCode, debit, credit);

            //                    note = "计提" + sheet.GetRow(i).GetCell(6).StringCellValue + "工资";
            //                    accontCode = "1003.01";
            //                    debit = "0";
            //                    credit = (sheet.GetRow(i).GetCell(28).NumericCellValue + sheet.GetRow(i).GetCell(29).NumericCellValue + sheet.GetRow(i).GetCell(30).NumericCellValue + sheet.GetRow(i).GetCell(31).NumericCellValue + sheet.GetRow(i).GetCell(34).NumericCellValue + sheet.GetRow(i).GetCell(39).NumericCellValue + sheet.GetRow(i).GetCell(43).NumericCellValue + sheet.GetRow(i).GetCell(27).NumericCellValue).ToString();
            //                    inentry(12, note, accontCode, debit, credit);
            //                    inkingdee();

            //                }


                            
            //            }
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //    //MessageBox.Show(dialog.f);






            //}
            //#endregion
        }


        string entry="";
        private void inentry(int i,string note,string accountcode,string debit,string credit,string dept,string project, string expense,string z)
        {
            if (entry != "")
                entry = entry + ",";
            //entry = entry + "{\"FEntryID\":" + i + ",\"FEXPLANATION\":\"" + note + "\",\"FACCOUNTID\":{\"FNumber\":\"" + accountcode + "\"},\"FDetailID\":{\"FDETAILID__FF100002\":{\"FNumber\":\"\"},\"FDETAILID__FF100003\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX10\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX11\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX4\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX5\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX6\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX7\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX8\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX9\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX12\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX13\":{\"FNumber\":\"\"}},\"FCURRENCYID\":{\"FNumber\":\"\"},\"FEXCHANGERATETYPE\":{\"FNumber\":\"\"},\"FEXCHANGERATE\":0,\"FUnitId\":{\"FNUMBER\":\"\"},\"FPrice\":0,\"FQty\":0,\"FAMOUNTFOR\":0,\"FDEBIT\":" + debit + ",\"FCREDIT\":" + credit + ",\"FSettleTypeID\":{\"FNumber\":\"\"},\"FSETTLENO\":\"\",\"FEXPORTENTRYID\":0}";
            //entry = entry + "{\"FACCOUNTID\": {\"FNumber\": \""+ accountcode+"\"}}";
            if (accountcode == "5001.01"|| accountcode == "5001.02" || accountcode == "1215.03.01" )
            {
                entry = entry + "{\"FACCOUNTID\":{\"FNumber\":\"" + accountcode + "\"},\"FDetailID\":{\"FDETAILID__FF100002\":{\"FNumber\":\""+z+"\"},\"FDETAILID__FF100003\":{\"FNumber\":\"" + project + "\"},\"FDETAILID__FFLEX10\":{\"FNumber\":\"" + project + "\"},\"FDETAILID__FFLEX11\":{\"FNumber\":\"0400101003\"},\"FDETAILID__FFLEX4\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX5\":{\"FNumber\":\"" + dept + "\"},\"FDETAILID__FFLEX6\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX7\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX8\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX9\":{\"FNumber\":\"" + expense + "\"},\"FDETAILID__FFLEX12\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX13\":{\"FNumber\":\"\"}},\"FCURRENCYID\":{\"FNumber\":\"PRE001\"},\"FEXCHANGERATETYPE\":{\"FNumber\":\"HLTX01_SYS\"},\"FEXCHANGERATE\":1.0,\"FUnitId\":{\"FNUMBER\":\"\"},\"FPrice\":0,\"FQty\":0,\"FAMOUNTFOR\":0,\"FDEBIT\":" + debit + ",\"FCREDIT\":" + credit + ",\"FSettleTypeID\":{\"FNumber\":\"\"},\"FSETTLENO\":\"\",\"FEXPORTENTRYID\":0, \"FEXPLANATION\": \"" + note + "\"}";
               //entry = entry + "{\"FACCOUNTID\":{\"FNumber\":\"" + accountcode + "\"},\"FDetailID\":{\"FDETAILID__FF100002\":{\"FNumber\":\"03\"},\"FDETAILID__FF100003\":{\"FNumber\":\"0400101005\"},\"FDETAILID__FFLEX10\":{\"FNumber\":\"02\"},\"FDETAILID__FFLEX11\":{\"FNumber\":\"0400101003\"},\"FDETAILID__FFLEX4\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX5\":{\"FNumber\":\"00101\"},\"FDETAILID__FFLEX6\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX7\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX8\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX9\":{\"FNumber\":\"0102\"},\"FDETAILID__FFLEX12\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX13\":{\"FNumber\":\"\"}},\"FCURRENCYID\":{\"FNumber\":\"PRE001\"},\"FEXCHANGERATETYPE\":{\"FNumber\":\"HLTX01_SYS\"},\"FEXCHANGERATE\":1.0,\"FUnitId\":{\"FNUMBER\":\"\"},\"FPrice\":0,\"FQty\":0,\"FAMOUNTFOR\":0,\"FDEBIT\":" + debit + ",\"FCREDIT\":" + credit + ",\"FSettleTypeID\":{\"FNumber\":\"\"},\"FSETTLENO\":\"\",\"FEXPORTENTRYID\":0, \"FEXPLANATION\": \"" + note + "\"}";
            }
            else
            {
                if(accountcode == "1003.01")
                {
                    entry = entry + "{\"FACCOUNTID\":{\"FNumber\":\"" + accountcode + "\"},\"FDetailID\":{\"FDETAILID__FF100002\":{\"FNumber\":\"" + z + "\"},\"FDETAILID__FF100003\":{\"FNumber\":\"" + project + "\"},\"FDETAILID__FFLEX10\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX11\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX4\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX5\":{\"FNumber\":\"" + dept + "\"},\"FDETAILID__FFLEX6\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX7\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX8\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX9\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX12\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX13\":{\"FNumber\":\"\"}},\"FCURRENCYID\":{\"FNumber\":\"PRE001\"},\"FEXCHANGERATETYPE\":{\"FNumber\":\"HLTX01_SYS\"},\"FEXCHANGERATE\":1.0,\"FUnitId\":{\"FNUMBER\":\"\"},\"FPrice\":0,\"FQty\":0,\"FAMOUNTFOR\":0,\"FDEBIT\":" + debit + ",\"FCREDIT\":" + credit + ",\"FSettleTypeID\":{\"FNumber\":\"\"},\"FSETTLENO\":\"\",\"FEXPORTENTRYID\":0, \"FEXPLANATION\": \"" + note + "\"}";
                    //entry = entry + "{\"FACCOUNTID\":{\"FNumber\":\"" + accountcode + "\"},\"FDetailID\":{\"FDETAILID__FF100002\":{\"FNumber\":\"03\"},\"FDETAILID__FF100003\":{\"FNumber\":\"0400101005\"},\"FDETAILID__FFLEX10\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX11\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX4\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX5\":{\"FNumber\":\"00101\"},\"FDETAILID__FFLEX6\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX7\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX8\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX9\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX12\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX13\":{\"FNumber\":\"\"}},\"FCURRENCYID\":{\"FNumber\":\"PRE001\"},\"FEXCHANGERATETYPE\":{\"FNumber\":\"HLTX01_SYS\"},\"FEXCHANGERATE\":1.0,\"FUnitId\":{\"FNUMBER\":\"\"},\"FPrice\":0,\"FQty\":0,\"FAMOUNTFOR\":0,\"FDEBIT\":" + debit + ",\"FCREDIT\":" + credit + ",\"FSettleTypeID\":{\"FNumber\":\"\"},\"FSETTLENO\":\"\",\"FEXPORTENTRYID\":0, \"FEXPLANATION\": \"" + note + "\"}";
                }
                else
                {
                    entry = entry + "{\"FACCOUNTID\":{\"FNumber\":\"" + accountcode + "\"},\"FDetailID\":{\"FDETAILID__FF100002\":{\"FNumber\":\"\"},\"FDETAILID__FF100003\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX10\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX11\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX4\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX5\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX6\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX7\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX8\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX9\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX12\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX13\":{\"FNumber\":\"\"}},\"FCURRENCYID\":{\"FNumber\":\"PRE001\"},\"FEXCHANGERATETYPE\":{\"FNumber\":\"HLTX01_SYS\"},\"FEXCHANGERATE\":1.0,\"FUnitId\":{\"FNUMBER\":\"\"},\"FPrice\":0,\"FQty\":0,\"FAMOUNTFOR\":0,\"FDEBIT\":" + debit + ",\"FCREDIT\":" + credit + ",\"FSettleTypeID\":{\"FNumber\":\"\"},\"FSETTLENO\":\"\",\"FEXPORTENTRYID\":0, \"FEXPLANATION\": \"" + note + "\"}";
                    //entry = entry + "{\"FACCOUNTID\":{\"FNumber\":\"" + accountcode + "\"},\"FDetailID\":{\"FDETAILID__FF100002\":{\"FNumber\":\"\"},\"FDETAILID__FF100003\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX10\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX11\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX4\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX5\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX6\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX7\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX8\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX9\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX12\":{\"FNumber\":\"\"},\"FDETAILID__FFLEX13\":{\"FNumber\":\"\"}},\"FCURRENCYID\":{\"FNumber\":\"PRE001\"},\"FEXCHANGERATETYPE\":{\"FNumber\":\"HLTX01_SYS\"},\"FEXCHANGERATE\":1.0,\"FUnitId\":{\"FNUMBER\":\"\"},\"FPrice\":0,\"FQty\":0,\"FAMOUNTFOR\":0,\"FDEBIT\":" + debit + ",\"FCREDIT\":" + credit + ",\"FSettleTypeID\":{\"FNumber\":\"\"},\"FSETTLENO\":\"\",\"FEXPORTENTRYID\":0, \"FEXPLANATION\": \"" + note + "\"}";
                }
              
            }
           
        }

        private void inkingdee()
        {


            K3CloudApiClient client = new K3CloudApiClient("http://172.16.120.253/K3Cloud/");
            var loginResult = client.ValidateLogin("5e9423fea8924d", loginname.Text.ToString(), password.Text.ToString(), 2052);
            var resultType = JObject.Parse(loginResult)["LoginResultType"].Value<int>();
            //登录结果类型等于1，代表登录成功
            if (resultType == 1)
            {
                int month = 0;
                int year = 0;
                if (int.Parse(DateTime.Now.Month.ToString()) == 1)
                {
                    month = 12;
                    year = int.Parse(DateTime.Now.ToString("yyyy")) - 1;
                }
                else
                {
                    month = int.Parse(DateTime.Now.Month.ToString())-1;
                    year = int.Parse(DateTime.Now.ToString("yyyy")) ;
                }
                int monthDay = DateTime.DaysInMonth(year, month);
                DateTime date = new DateTime(year, month, monthDay);
                string a = "{\"Creator\":\"\",\"NeedUpDateFields\":[],\"NeedReturnFields\":[],\"IsDeleteEntry\":\"true\",\"SubSystemId\":\"\",\"IsVerifyBaseDataField\":\"false\",\"IsEntryBatchFill\":\"true\",\"ValidateFlag\":\"true\",\"NumberSearch\":\"true\",\"InterationFlags\":\"\",\"IsAutoSubmitAndAudit\":\"false\",\"Model\":{\"FVOUCHERID\":0,\"FAccountBookID\":{\"FNumber\":\"001\"},\"FDate\":\"" + DateTime.Now.ToString("yyyy-MM-dd") + "\",\"FVOUCHERGROUPID\":{\"FNumber\":\"PZZ1\"},\"FVOUCHERGROUPNO\":\"\",\"FATTACHMENTS\":0,\"FISADJUSTVOUCHER\":\"false\",\"FDocumentStatus\":\"Z\",\"FYEAR\":"+year.ToString()+",\"FSourceBillKey\":{\"FNumber\":\"\"},\"FPERIOD\":"+month.ToString() + ",\"FIMPORTVERSION\":\"\",\"FEntity\":[" + entry + "]}}";
                //var los=
                var js1=
               //client.Save("GL_VOUCHER", "{\"Creator\":\"\",\"NeedUpDateFields\":[],\"NeedReturnFields\":[],\"IsDeleteEntry\":\"true\",\"SubSystemId\":\"\",\"IsVerifyBaseDataField\":\"false\",\"IsEntryBatchFill\":\"true\",\"ValidateFlag\":\"true\",\"NumberSearch\":\"true\",\"InterationFlags\":\"\",\"IsAutoSubmitAndAudit\":\"false\",\"Model\":{\"FVOUCHERID\":0,\"FAccountBookID\":{\"FNumber\":\"001\"},\"FDate\":\"" + DateTime.Now.ToString() + "\",\"FVOUCHERGROUPID\":{\"FNumber\":\"PZZ1\"},\"FVOUCHERGROUPNO\":\"\",\"FATTACHMENTS\":0,\"FISADJUSTVOUCHER\":\"false\",\"FDocumentStatus\":\"Z\",\"FYEAR\":0,\"FSourceBillKey\":{\"FNumber\":\"\"},\"FPERIOD\":0,\"FIMPORTVERSION\":\"\",\"FEntity\":[" + entry + "]}}");

                client.Save("GL_VOUCHER", "{\"Creator\":\"\",\"NeedUpDateFields\":[],\"NeedReturnFields\":[],\"IsDeleteEntry\":\"true\",\"SubSystemId\":\"\",\"IsVerifyBaseDataField\":\"false\",\"IsEntryBatchFill\":\"true\",\"ValidateFlag\":\"true\",\"NumberSearch\":\"true\",\"InterationFlags\":\"\",\"IsAutoSubmitAndAudit\":\"false\",\"Model\":{\"FVOUCHERID\":0,\"FAccountBookID\":{\"FNumber\":\"001\"},\"FDate\":\"" + date.ToString("yyyy-MM-dd") + "\",\"FVOUCHERGROUPID\":{\"FNumber\":\"PZZ1\"},\"FVOUCHERGROUPNO\":\"\",\"FATTACHMENTS\":0,\"FISADJUSTVOUCHER\":\"false\",\"FDocumentStatus\":\"Z\",\"FYEAR\":" + year.ToString() + ",\"FSourceBillKey\":{\"FNumber\":\"\"},\"FPERIOD\":" +month.ToString() + ",\"FIMPORTVERSION\":\"\",\"FEntity\":[" + entry + "]}}");
                //client.Save("GL_VOUCHER", "{\"Creator\":\"\",\"NeedUpDateFields\":[],\"NeedReturnFields\":[],\"IsDeleteEntry\":\"true\",\"SubSystemId\":\"\",\"IsVerifyBaseDataField\":\"false\",\"IsEntryBatchFill\":\"true\",\"ValidateFlag\":\"true\",\"NumberSearch\":\"true\",\"InterationFlags\":\"\",\"IsAutoSubmitAndAudit\":\"false\",\"Model\":{\"FVOUCHERID\":0,\"FAccountBookID\":{\"FNumber\":\"001\"},\"FDate\":\"" + DateTime.Now.ToString() + "\",\"FVOUCHERGROUPID\":{\"FNumber\":\"PZZ1\"},\"FVOUCHERGROUPNO\":\"\",\"FATTACHMENTS\":0,\"FISADJUSTVOUCHER\":\"false\",\"FDocumentStatus\":\"Z\",\"FYEAR\":0,\"FSourceBillKey\":{\"FNumber\":\"\"},\"FPERIOD\":0,\"FIMPORTVERSION\":\"\",\"FEntity\":[{\"FACCOUNTID\": {\"FNumber\": \"1001\"}},{\"FACCOUNTID\": {\"FNumber\": \"1002.01.01\"}}]}}");
                JObject re1 = JObject.Parse(js1);
                JObject r1 = re1["Result"]["ResponseStatus"] as JObject;
                if (r1["IsSuccess"].ToString() == "False")
                {
                    MessageBox.Show(r1.ToString());

                    textBox1.Text = "{\"Creator\":\"\",\"NeedUpDateFields\":[],\"NeedReturnFields\":[],\"IsDeleteEntry\":\"true\",\"SubSystemId\":\"\",\"IsVerifyBaseDataField\":\"false\",\"IsEntryBatchFill\":\"true\",\"ValidateFlag\":\"true\",\"NumberSearch\":\"true\",\"InterationFlags\":\"\",\"IsAutoSubmitAndAudit\":\"false\",\"Model\":{\"FVOUCHERID\":0,\"FAccountBookID\":{\"FNumber\":\"001\"},\"FDate\":\"" + DateTime.Now.ToString("yyyy-MM-dd") + "\",\"FVOUCHERGROUPID\":{\"FNumber\":\"PZZ1\"},\"FVOUCHERGROUPNO\":\"\",\"FATTACHMENTS\":0,\"FISADJUSTVOUCHER\":\"false\",\"FDocumentStatus\":\"Z\",\"FYEAR\":" + DateTime.Now.ToString("yyyy") + ",\"FSourceBillKey\":{\"FNumber\":\"\"},\"FPERIOD\":" + DateTime.Now.Month.ToString() + ",\"FIMPORTVERSION\":\"\",\"FEntity\":[" + entry + "]}}";
                }
                
                //MessageBox.Show(r1.ToString());

                //object[] saveInfo = new object[]
                // {
                //    re1,
                //    r1
                // };
                //调用保存接口 
                //client.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Save", saveInfo);
            }
            else
            {
                MessageBox.Show("登陆失败");
            }
           


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int year;
            int month;
            year = int.Parse(textBox2.Text);
            month = int.Parse(comboBox1.Text);

            DataTable dt1 = _BLL_POP_Select.Client_Select_Contract(year, month).Tables[0];
           
            
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string note;
                string accontCode;
                string debit;
                string credit;
                string depart;
                string project;
                string z;
                string yyyy;
                string mm;
                yyyy = textBox2.Text.ToString();
                mm = comboBox1.Text.ToString();
                depart = dt1.Rows[i]["部门"].ToString();
                project = dt1.Rows[i]["project"].ToString();
                    z = dt1.Rows[i]["expense"].ToString();
                if (project is null || project == "")
                {
                    project = "0400101005";
                }
                if (z is null || z == "")
                {
                    z = "02";
                }
                entry = "";
               
                if (float.Parse(dt1.Rows[i]["应发工资"].ToString()) != 0  )
                {
                    note = "计提" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "工资";
                    accontCode = "5001.02";
                    debit = double.Parse(dt1.Rows[i]["应发工资"].ToString()).ToString();
                    credit = "0";
                    
                    if (debit != "" && debit != null && debit != "0")
                    {
                        inentry(1, note, accontCode, debit, credit, depart, project,"0101",z);
                    }
                }


                if (float.Parse(dt1.Rows[i]["应发工资"].ToString()) != 0  )
                {
                    note = "计提" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "工资";
                    accontCode = "2201.01";
                    debit = "0";
                    credit = double.Parse(dt1.Rows[i]["应发工资"].ToString()).ToString();
                    
                    if (credit != "" && credit != null && credit != "0")
                    {
                        inentry(2, note, accontCode, debit, credit, depart,project,"0101", z);
                    }
                }

                if (float.Parse(dt1.Rows[i]["个人缴纳住房公积金"].ToString()) != 0|| float.Parse(dt1.Rows[i]["个税"].ToString()) != 0|| float.Parse(dt1.Rows[i]["个人缴纳保险合计"].ToString()) != 0)
                {
                    note = "代扣" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "工资";
                    accontCode = "2201.01";
                    string a;
                    string b;
                    string c;
                    if (dt1.Rows[i]["个人缴纳住房公积金"].ToString() == "" || dt1.Rows[i]["个人缴纳住房公积金"].ToString() == "")
                        a = "0";
                    else
                        a = dt1.Rows[i]["个人缴纳住房公积金"].ToString();
                    if (dt1.Rows[i]["个税"].ToString() == "" || dt1.Rows[i]["个税"].ToString() == "")
                        b = "0";
                    else
                        b = dt1.Rows[i]["个税"].ToString();
                    if (dt1.Rows[i]["个人缴纳保险合计"].ToString() == "" || dt1.Rows[i]["个人缴纳保险合计"].ToString() == "")
                        c = "0";
                    else
                        c = dt1.Rows[i]["个人缴纳保险合计"].ToString();

                    debit = (Decimal.Parse(a) + Decimal.Parse(c) + Decimal.Parse(b)).ToString(); ;
                    credit = "0";
                    if (debit != "" && debit != null && debit != "0")
                    {
                        inentry(3, note, accontCode, debit, credit, depart,project,"0106", z);
                    }
                }

                if (float.Parse(dt1.Rows[i]["个人缴纳住房公积金"].ToString()) != 0)
                {
                    note = "代扣" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "公积金";
                    accontCode = "2305.04";
                    debit = "0";
                    credit = Decimal.Parse(dt1.Rows[i]["个人缴纳住房公积金"].ToString()).ToString();
                    if (credit != "" && credit != null && credit != "0")
                    {
                        inentry(4, note, accontCode, debit, credit, depart , project, "0106", z);
                    }
                }

                if (float.Parse(dt1.Rows[i]["个人缴纳保险合计"].ToString()) != 0 )
                {
                    note = "代扣" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "社会保险";
                    accontCode = "2305.03";
                    debit = "0";
                    credit = Decimal.Parse(dt1.Rows[i]["个人缴纳保险合计"].ToString()).ToString();
                    if (credit != "" && credit != null && credit != "0")
                    {
                        inentry(5, note, accontCode, debit, credit, depart, project, "0105", z);
                    }
                }

                if (float.Parse(dt1.Rows[i]["个税"].ToString()) != 0  )
                {
                    if (Decimal.Parse(dt1.Rows[i]["个税"].ToString()) != 0)
                    {
                        note = "代扣" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "个税";
                        accontCode = "2101.11";
                        debit = "0";
                        credit = Decimal.Parse(dt1.Rows[i]["个税"].ToString()).ToString();
                        if (credit != "" && credit != null && credit != "0")
                        {
                            inentry(6, note, accontCode, debit, credit, depart, project, "0101", z);
                        }
                    }

                }

                if (float.Parse(dt1.Rows[i]["公司缴纳住房公积金"].ToString()) != 0    )
                {
                    note = "计提" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "公积金单位承担部分";
                    accontCode = "5001.02";
                    debit = dt1.Rows[i]["公司缴纳住房公积金"].ToString();
                    credit = "0";
                    if (credit != "" && debit != null && debit != "0")
                    {
                        inentry(7, note, accontCode, debit, credit, depart, project, "0106", z);
                    }
                }

                if (float.Parse(dt1.Rows[i]["公司缴纳住房公积金"].ToString()) != 0      )
                {

                    note = "计提" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "公积金单位承担部分";
                    accontCode = "2201.04";
                    debit = "0";
                    credit = dt1.Rows[i]["公司缴纳住房公积金"].ToString();
                    if (debit != "" && credit != null && credit != "0")
                    {
                        inentry(8, note, accontCode, debit, credit, depart, project, "0106", z);
                    }
                }

                if (float.Parse(dt1.Rows[i]["公司缴纳保险合计"].ToString()) != 0  )
                {

                    note = "计提" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "社保单位承担部分";
                    accontCode = "5001.02";
                    debit = dt1.Rows[i]["公司缴纳保险合计"].ToString();
                    credit = "0";
                    if (credit != "" && debit != null && debit != "0")
                    {
                        inentry(9, note, accontCode, debit, credit, depart, project, "0105", z);
                    }
                }

                if (float.Parse(dt1.Rows[i]["公司缴纳保险合计"].ToString()) != 0   )
                {
                    note = "计提" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "社保单位承担部分";
                    accontCode = "2201.03";
                    debit = "0";
                    credit = dt1.Rows[i]["公司缴纳保险合计"].ToString();
                    if (debit != "" && credit != null && credit != "0")
                    {
                        inentry(10, note, accontCode, debit, credit, depart, project, "0105", z);
                    }
                }

                if (float.Parse(dt1.Rows[i]["应发工资"].ToString()) != 0    )
                {
                    note = "计提" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "工资";
                    accontCode = "1215.03.01";
                    string a;
                    string b;
                    string c;
                    if (dt1.Rows[i]["应发工资"].ToString() == "" || dt1.Rows[i]["应发工资"].ToString() == "")
                        a = "0";
                    else
                        a = dt1.Rows[i]["应发工资"].ToString();
                    if (dt1.Rows[i]["公司缴纳保险合计"].ToString() == "" || dt1.Rows[i]["公司缴纳保险合计"].ToString() == "")
                        b = "0";
                    else
                        b = dt1.Rows[i]["公司缴纳保险合计"].ToString();
                    if (dt1.Rows[i]["公司缴纳住房公积金"].ToString() == "" || dt1.Rows[i]["公司缴纳住房公积金"].ToString() == "")
                        c = "0";
                    else
                        c = dt1.Rows[i]["公司缴纳住房公积金"].ToString();

                    debit = (Decimal.Parse(a) + Decimal.Parse(b) + Decimal.Parse(c)).ToString();
                    credit = "0";
                    if (debit != "" && debit != null && debit != "0")
                    {
                        inentry(11, note, accontCode, debit, credit, depart, project, "0101", z);
                    }
                }

                if (float.Parse(dt1.Rows[i]["应发工资"].ToString()) != 0   )

                {
                    note = "计提" + dt1.Rows[i]["核算结果组织名称"] + yyyy + mm + "工资";
                    accontCode = "1003.01";
                    string a;
                    string b;
                    string c;
                    if (dt1.Rows[i]["应发工资"].ToString() == "" || dt1.Rows[i]["应发工资"].ToString() == "")
                        a = "0";
                    else
                        a = dt1.Rows[i]["应发工资"].ToString();
                    if (dt1.Rows[i]["公司缴纳保险合计"].ToString() == "" || dt1.Rows[i]["公司缴纳保险合计"].ToString() == "")
                        b = "0";
                    else
                        b = dt1.Rows[i]["公司缴纳保险合计"].ToString();
                    if (dt1.Rows[i]["公司缴纳住房公积金"].ToString() == "" || dt1.Rows[i]["公司缴纳住房公积金"].ToString() == "")
                        c = "0";
                    else
                        c = dt1.Rows[i]["公司缴纳住房公积金"].ToString();
                    debit = "0";
                    credit = (Decimal.Parse(a) + Decimal.Parse(b) + Decimal.Parse(c)).ToString();

                    if (credit != "" && credit != null && credit != "0")
                    {
                        inentry(12, note, accontCode, debit, credit, depart, project, "0101", z);
                    }
                }
                inkingdee();

            }
            MessageBox.Show("传输成功");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}