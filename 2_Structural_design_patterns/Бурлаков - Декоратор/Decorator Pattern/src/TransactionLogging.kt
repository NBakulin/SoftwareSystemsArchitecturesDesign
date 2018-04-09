
//класс Декоратор
class TransactionLogging
    ( sender: Account, receiver: Account, amount: Int) : Transaction(sender, receiver, amount) {

    override fun sendMoney(){
        super.sendMoney() // функция из базововго класса
        saveTransaction() // дополнительный функционал
    }

    //дополнительный функционал, это класс декоратор еще и сохраняет данные о транзакции в журнал
    private fun saveTransaction(){
        Journal.addRecord( this )
    }
}