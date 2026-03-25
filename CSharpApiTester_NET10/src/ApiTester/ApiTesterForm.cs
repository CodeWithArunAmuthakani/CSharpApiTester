using System;using System.Net.Http;using System.Text;using System.Windows.Forms;
namespace ApiTester{
 public partial class ApiTesterForm:Form{
  HttpClient client=new HttpClient();
  public ApiTesterForm(){InitializeComponent();}
  private async void btnSend_Click(object sender,EventArgs e){
    try{
      string url=txtUrl.Text;
      string method=cmbMethod.SelectedItem.ToString();
      HttpRequestMessage req=new HttpRequestMessage(new HttpMethod(method),url);
      if(method!="GET" && txtBody.Text.Trim().Length>0){
        req.Content=new StringContent(txtBody.Text,Encoding.UTF8,"application/json");
      }
      foreach(DataGridViewRow r in dgvHeaders.Rows){
        if(r.Cells[0].Value!=null){req.Headers.TryAddWithoutValidation(r.Cells[0].Value.ToString(),r.Cells[1].Value?.ToString()??"");}
      }
      var start=DateTime.Now;
      var res=await client.SendAsync(req);
      var end=DateTime.Now;

      txtStatus.Text=$"{(int)res.StatusCode} {res.ReasonPhrase}";
      txtTime.Text=$"{(end-start).TotalMilliseconds} ms";
      txtResponse.Text=await res.Content.ReadAsStringAsync();
    }catch(Exception ex){MessageBox.Show(ex.Message);} }
 }
}
