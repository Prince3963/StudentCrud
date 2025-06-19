namespace StudentManagement.HelperServices
{
    public class ServiceResponse<g>
    {
        public g? data { get; set; }
        public string? message { get; set; }
        public bool? status { get; set; }
    }
}
