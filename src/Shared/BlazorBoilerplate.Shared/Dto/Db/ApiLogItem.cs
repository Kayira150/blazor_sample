using Breeze.Sharp;
using System;

namespace BlazorBoilerplate.Shared.Dto.Db
{
    public partial class ApiLogItem : BaseEntity
    {

        public Int64 Id
        {
            get { return GetValue<Int64>(); }
            set { SetValue(value); }
        }

        public Guid? ApplicationUserId
        {
            get { return GetValue<Guid?>(); }
            set { SetValue(value); }
        }

        public String IPAddress
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String Method
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String Path
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String QueryString
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String RequestBody
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public DateTime RequestTime
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        public String ResponseBody
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public Int64 ResponseMillis
        {
            get { return GetValue<Int64>(); }
            set { SetValue(value); }
        }

        public Int32 StatusCode
        {
            get { return GetValue<Int32>(); }
            set { SetValue(value); }
        }

   }
}
