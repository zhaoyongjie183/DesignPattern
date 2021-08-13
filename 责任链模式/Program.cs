// See https://aka.ms/new-console-template for more information

using 责任链模式;

//责任链适用于 工作流、审批流

PurchaseBill bill = new PurchaseBill()
{
    BilNo = "CGDD001",
    MaterialName = "惠普电脑",
    Qty = 50,
    Price = 5000,
    BillMaker = new Purchaser("采购员--小责")
    //BillMaker = new Manager("经理--任经理")
    //BillMaker = new CEO("CEO--链总")
};

Console.WriteLine(string.Format("创建采购申请单：{0};申请购买{1}台{2}", bill.BilNo, bill.Qty, bill.MaterialName));

bill.BillMaker.HandleBill(bill);

Console.ReadLine();