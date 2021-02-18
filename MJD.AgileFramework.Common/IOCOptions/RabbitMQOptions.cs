using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJD.AgileFramework.Common.IOCOptions
{
    public class RabbitMQOptions
    {
        ///// <summary>
        ///// exchange---queue
        ///// </summary>
        //private static Dictionary<string, string> RabbitMQ_Mapping = new Dictionary<string, string>();
        //private static readonly object RabbitMQOptions_Lock = new object();
        //public void Init(string exchangeName, string queueName)
        //{
        //    lock (RabbitMQOptions_Lock)
        //    {
        //        RabbitMQ_Mapping[exchangeName] = queueName;
        //    }
        //}

        public string HostName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }

    public class RabbitMQConsumerModel
    {
        /// <summary>
        /// 生产者指定，交换机
        /// </summary>
        public string ExchangeName { get; set; }
        /// <summary>
        /// 自己起的名字
        /// </summary>
        public string QueueName { get; set; }
    }

    public class RabbitMQExchangeQueueName
    {
        public static readonly string SKUCQRS_Exchange = "MJD.MSACormmerce.SKUCQRS.Exchange";
        public static readonly string SKUCQRS_Queue_StaticPage = "MJD.MSACormmerce.SKUCQRS.Queue.StaticPage";
        public static readonly string SKUCQRS_Queue_ESIndex = "MJD.MSACormmerce.SKUCQRS.Queue.ESIndex";


        public static readonly string SKUWarmup_Exchange = "MJD.MSACormmerce.Warmup.Exchange";
        public static readonly string SKUWarmup_Queue_StaticPage = "MJD.MSACormmerce.Warmup.Queue.StaticPage";
        public static readonly string SKUWarmup_Queue_ESIndex = "MJD.MSACormmerce.Warmup.Queue.ESIndex";

        /// <summary>
        /// 订单创建后的交换机
        /// </summary>
        public static readonly string OrderCreate_Exchange = "MJD.MSACormmerce.OrderCreate.Exchange";
        public static readonly string OrderCreate_Queue_CleanCart = "MJD.MSACormmerce.OrderCreate.Queue.CleanCart";

        /// <summary>
        /// 订单创建后的交换机,支付状态的
        /// </summary>
        public static readonly string OrderPay_Exchange = "MJD.MSACormmerce.OrderPay.Exchange";
        public static readonly string OrderPay_Queue_RefreshPay = "MJD.MSACormmerce.OrderPay.Queue.RefreshPay";

        /// <summary>
        /// 创建订单后的延时队列配置
        /// </summary>
        public static readonly string OrderCreate_Delay_Exchange = "MJD.MSACormmerce.OrderCreate.DelayExchange";
        public static readonly string OrderCreate_Delay_Queue_CancelOrder = "MJD.MSACormmerce.OrderCreate.DelayQueue.CancelOrder";
    }

}
