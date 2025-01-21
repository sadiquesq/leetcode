public class Solution {
    public string ConvertDateToBinary(string date) {
        string year=Convert.ToString(int.Parse(date.Substring(0,4)),2);
        string month=Convert.ToString(int.Parse(date.Substring(5,2)),2);
        string day=Convert.ToString(int.Parse(date.Substring(8,2)),2);

       return year+"-"+month+"-"+day;

    }
}