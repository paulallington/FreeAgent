using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeAgent
{
    public class PayrollPeriod : BaseModel
    {
        public string url { get; set; }
        public string period { get; set; }
        public string frequency { get; set; }
        public string dated_on { get; set; }
        public List<Payslip> payslips { get; set; }
        public string status { get; set; }
    }

    public class Payslip
    {
        public string user { get; set; }
        public string tax_code { get; set; }
        public string dated_on { get; set; }
        public decimal basic_pay { get; set; }
        public decimal tax_deducted { get; set; }
        public decimal employee_ni { get; set; }
        public decimal employer_ni { get; set; }
        public decimal other_deductions { get; set; }
        public decimal student_loan_deduction { get; set; }
        public decimal overtime { get; set; }
        public decimal commission { get; set; }
        public decimal bonus { get; set; }
        public decimal allowance { get; set; }
        public decimal statutory_sick_pay { get; set; }
        public decimal statutory_maternity_pay { get; set; }
        public decimal statutory_paternity_pay { get; set; }
        public decimal statutory_adoption_pay { get; set; }
        public decimal absence_payments { get; set; }
        public decimal other_payments { get; set; }
        public decimal employee_pension { get; set; }
        public decimal employer_pension { get; set; }
        public decimal attachments { get; set; }
        public decimal payroll_giving { get; set; }
        public string ni_calc_type { get; set; }
        public string frequency { get; set; }
        public decimal additional_statutory_paternity_pay { get; set; }
        public decimal deductions_subject_to_nic_but_not_paye { get; set; }
        public decimal other_deductions_from_net_pay { get; set; }
        public decimal employee_pension_not_under_net_pay { get; set; }
        public decimal deduction_free_pay { get; set; }
        public string ni_letter { get; set; }
        public bool deduct_student_loan { get; set; }
        public bool week_1_month_1_basis { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class PayrollPeriodWrapper
    {
        public PayrollPeriodWrapper()
        {
            period = new PayrollPeriod();
        }

        public PayrollPeriod period { get; set; }
    }

    public class PayrollWrapper
    {
        public PayrollWrapper()
        {
            periods = new List<PayrollPeriod>();
        }

        public List<PayrollPeriod> periods { get; set; }
    }
}
