package multiton

import java.util.HashMap

object ConnectionManager {

    private val connectionPool = HashMap<String, Connection>()


    fun getConnection(key: String): Connection? {

        if (connectionPool.containsKey(key))
            return connectionPool[key]
        else throw Exception("No such Connection")
    }

    fun createConnection(key:String, connection: Connection): Connection
    {
        if(!connectionPool.containsKey(key))
            connectionPool[key] = connection
        else throw Exception("Key $key already exist")
        return connection
    }

    fun createConnection(key:String, connectionString: String) : Connection
    {
        var connection = Connection(connectionString)

        createConnection(key, connection)
        return connection
    }
}
