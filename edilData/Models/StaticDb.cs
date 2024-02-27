namespace edilData.Models
{
    public static class StaticDb
    {
        private static int _maxId = 3;
        private static int payId = 0;
        public static List<Payment> _payments = [ 
            ];
        public static List<Employee> _employee = [
            new Employee()
            {
                EmployeeId = 1,
                FirstName = "Paride",
                LastName = "Ficiente",
                Address = "Via vai 2",
                FiscalCode = "ntnrkr32f12h121g",
                Conjugality = "Married",
                Children = 2,
                Role = "Clown"
            },
            new Employee()
            {
                EmployeeId = 2,
                FirstName = "Ivo",
                LastName = "Avido",
                Address = "Via Fuffolo 10",
                FiscalCode = "ntnrkr32f12h145g",
                Conjugality = "Single",
                Children = 0,
                Role = "Actor"
            },
            new Employee()
            {
                EmployeeId = 3,
                FirstName = "Bruno",
                LastName = "Liegibastonliegi",
                Address = "Via pannocchia 11",
                FiscalCode = "nnarkr32f12h121g",
                Conjugality = "Married",
                Children = 1,
                Role = "Director"
            },
        ];

        public static Payment Add(DateOnly period, double amount, string type)
        {
            payId++;
            var payment = new Payment()
            {
                IdPayment = payId,
                PaymentPeriod = period,
                PaymentAmount = amount,
                PaymentType = type
            };
            _payments.Add(payment);
            return payment;
        }

        public static Employee Add(string firstName, string lastName, string address, string fiscalCode, string conjugality, int children, string role)
        {
            _maxId++;
            var employee = new Employee()
            {
                EmployeeId = _maxId,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                FiscalCode = fiscalCode,
                Conjugality = conjugality,
                Children = children,
                Role = role
            };
            _employee.Add(employee);
            return employee;
        }


    }
}
