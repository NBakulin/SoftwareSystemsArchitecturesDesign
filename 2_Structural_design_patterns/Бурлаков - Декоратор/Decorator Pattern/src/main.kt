fun main(args: Array<String>){
    //Есть два счета В и С
    var b = Account(1,"1",12, true)

    var c = Account(2, "2", 0, false)

    // Между ними происходят тре транзакции с сохранением в журнал
    var trans = TransactionLogging(b,c,10)
    var trans1 = TransactionLogging(b,c,100)
    var trans2 = TransactionLogging(b,c,1000)

    trans.sendMoney()
    trans1.sendMoney()
    trans2.sendMoney()

    var list = Journal.findBySender(b)
}