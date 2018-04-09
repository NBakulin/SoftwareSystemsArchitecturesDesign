object Journal{

    private var journal : ArrayList<Transaction> = ArrayList()

    fun addRecord(transaction: Transaction){
        var cloneTransaction = Transaction(transaction.sender.copy(), transaction.receiver.copy(), transaction.amount)
        journal.add(cloneTransaction)
    }


    fun findBySender(sender: Account) : ArrayList<Transaction>{
        return journal.filter { x -> x.sender.id == sender.id } as ArrayList<Transaction>
    }

    fun findByReceiver(receiver: Account) : ArrayList<Transaction>{
        return journal.filter { x -> x.receiver.id == receiver.id } as ArrayList<Transaction>
    }

    fun findByHash(hash: Int) : Transaction{
        return (journal.filter { x -> x.hashCode() == hash } as ArrayList<Transaction>).first()
    }
}