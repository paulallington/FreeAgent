using System;
using System.Collections.Generic;
using System.IO;
using RestSharp;


namespace FreeAgent
{
    public class PayrollClient : ResourceClient<PayrollPeriodWrapper, PayrollWrapper, PayrollPeriod>
    {
        public PayrollClient(FreeAgentClient client) : base(client) {}
        
        public override string ResouceName { get { return "payroll"; } } 

        public override PayrollPeriodWrapper WrapperFromSingle(PayrollPeriod single)
        {
            return new PayrollPeriodWrapper { period = single };
        }
        public override List<PayrollPeriod> ListFromWrapper(PayrollWrapper wrapper)
        {
            return wrapper.periods;
        }

        public override PayrollPeriod SingleFromWrapper(PayrollPeriodWrapper wrapper)
        {
            return wrapper.period;
        }

        public List<PayrollPeriod> All(int year)
        {
            return All((r) =>
            {
                r.Resource += "/" + year;
            });
        }
    }
}

