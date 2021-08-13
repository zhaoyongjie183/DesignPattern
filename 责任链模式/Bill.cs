using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：                                                    
*│　作    者：赵永杰                                             
*│　版    本：1.0                                                 
*│　创建时间：2021-08-13 16:32:57                            
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： 责任链模式                              
*│　类    名： Bill                                      
*└──────────────────────────────────────────────────────────────┘
*/
namespace 责任链模式
{
    /// <summary>
    /// 单据状态枚举
    /// </summary>
    public enum BillStatus
    {
        Open,
        Saved,
        Submitted,
        Audited
    }

    public abstract class Bill
    {
        public string BillName { get; set; }

        public string BilNo { get; set; }

        public BillStatus Status { get; set; }

        public string MaterialName { get; set; }

        public int Qty { get; set; }

        public decimal Price { get; set; }

        public decimal Amount
        {
            get
            {
                return Qty * Price;
            }
        }

        /// <summary>
        /// 做单员
        /// </summary>
        public BillHandler BillMaker { get; set; }
    }

    public class PurchaseBill : Bill
    {
        public PurchaseBill()
        {
            base.Status = BillStatus.Open;
            base.BillName = "采购申请单";
        }
    }
}
