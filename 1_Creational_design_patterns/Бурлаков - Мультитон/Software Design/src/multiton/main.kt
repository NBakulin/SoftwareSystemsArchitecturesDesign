package multiton
fun main(args: Array<String>) {

    var create1 = ConnectionManager.createConnection("1", "192.168.0.1")
    var create2 = ConnectionManager.createConnection("2", "192.168.0.2")

    println("Connection ${create1.connectionString} was created")
    println("Connection ${create2.connectionString} was created")

    val mainConnection = ConnectionManager.getConnection("1")
    val secondConnection = ConnectionManager.getConnection("2")

    val otherMainConnection = ConnectionManager.getConnection("1")
    val otherSecondConnection = ConnectionManager.getConnection("2")

    val main = mainConnection == otherMainConnection
    val second = secondConnection == otherSecondConnection

    val mainObj = mainConnection === otherMainConnection
    val secondObj = secondConnection === otherSecondConnection

    println()
    println(main)
    println("Main connection: Connection string: ${mainConnection?.connectionString}")
    println(second)
    println("Second connection: Connection string: ${secondConnection?.connectionString}")
    println(mainObj)
    println("Main connection: Connection string: ${mainConnection?.connectionString}")
    println(secondObj)
    println("Second connection: Connection string: ${secondConnection?.connectionString}")
}