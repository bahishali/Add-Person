namespace ClassLibrary1
{
    public class Employee

    {
        public int Id { get; set; }
        public string Name { get; set; }
        internal decimal Salary { get; set; } //class1 içiinde görülebiliyor ama samp1 den çağırılmıyor
        public decimal Salary { get; set; } //class1 içiinde görülebiliyor samp1 den de çağırılabiliyor

    }
}