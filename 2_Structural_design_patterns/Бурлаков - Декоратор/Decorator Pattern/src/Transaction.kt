 open class Transaction (var sender: Account, var receiver: Account, var amount: Int) {

     private var hashSum = hashCode()

     private lateinit var state: State

     private fun checkSender() : Boolean {
         return sender.money >= amount || sender.isOverDraft
     }

     open fun sendMoney() {
         if (!checkSender()) state = State.FAILED
         else {
             sender.money -= amount
             receiver.money += amount
             state = State.COMPLETED
         }
     }

     override fun hashCode():Int{
         val hashString = receiver.name + sender.name + amount.toString()
         return hashString.hashCode()
     }
}