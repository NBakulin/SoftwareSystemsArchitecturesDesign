 open class Transaction (var sender: Account, var receiver: Account, var amount: Int) {

     private var hashSum = hashCode()

     var state: TransactionState = TransactionStarted()

     private fun checkSender() : Boolean {
         return sender.money >= amount || sender.isOverDraft
     }

     open fun sendMoney() {
         if (!checkSender()) state = TransactionComplited()
         else {
             sender.money -= amount
             receiver.money += amount
             state = TransactionFailed()
         }
     }

     override fun hashCode():Int{
         val hashString = receiver.name + sender.name + amount.toString()
         return hashString.hashCode()
     }
}