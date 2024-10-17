namespace hotels_api.Data
{
    public class Country
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public string ShortName { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}
