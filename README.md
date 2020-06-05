# Databases-for-Developers
Repo for my course in database for developers 

# Sample DB Questions

## All Database Types

### 1. Explain the following terms: data, information, database, and databasemanagement system. What is the difference? Give examples.

**Data** is any sort of information that can be stored in a computer memory - which then later can be used on a frontend or to manage a order from an  E-commerce platform.

**Information** is data on data?

**Database** is a place to store *data*, the numerous different databases, each have their own strengths and weakness.

**DBMS** is a software used to perform different operations like CRUD. Again the different databases excel at different usecases.

### 2. What is called a database schema? Which databases enable enforcing a hard schema, which are schemaless, and which enable storing semi-structured data?

A **schema** is the data structure of a database table, in RDBMS, such as PostgreSQL, every database table should have a fixed data structure.

**Schemaless** means the database don't have fixed data structure, such as MongoDB, it has JSON-style data store, you can change the data structure as you wish.

SQL Databases (we have worked with):

- PostgreSQL
- MySQL

NoSQL Databases (we have worked with):

- MongoDB
- Redis
- CouchDB
- Neo4j
- HBase

MongoDB uses JSON which is a **semi-structured** data.

### 3. Explain the difference between logical data model and underlying physical data storage organisation. Give examples for some of the databases you are familiar with.

https://www.datamodel.com/index.php/articles/what-are-conceptual-logical-and-physical-data-models/?cn-reloaded=1

![](https://i.imgur.com/ZVIQ7Ls.png)

Logical: SQL?

Physical: JSON/XML/NoSQL?

### 4. What is called a database transaction? Which are the main properties of a transaction? Explain ACID properties.

A **database transaction** is a unit of work that is either completed as a unit or undone as a unit. Proper database transaction processing is critical to maintaining the integrity of your databases.

**A**: Atomic - means that you guarantee that either all of the transaction succeeds or none of it does "All or Nothing"
**C**: Consistency - means that all your data is consistent.
**I**: Isolation - means that all transactions will occur in isolation. No transaction will be affected by any other transaction. In other words, a transaction cannot read data from any other transaction that has not yet completed.
**D**: Durability - means that, once a transaction is committed, it will remain in the system – even if there’s a system crash immediately following the transaction. Any changes from the transaction must be stored permanently.

### 5. Explain the concurrency problem in database implementation and the techniques for controlling it. How does it relate to transaction management and isolation? Which are the basic transaction isolation levels? 

Concurrency control is provided in a database to:

https://www.geeksforgeeks.org/concurrency-control-techniques/

- enforce isolation among transactions.
- preserve database consistency through consistency preserving execution of transactions.
- resolve read-write and write-read conflicts.

There's four techniques to control these:
- Two-Phase Locking Protocol
- Time Stamp Ordering Protocol
- Multi Version Concurrency Control
- Validation Concurrency Control 

**Transaction Isolaion Levels**
- Serializable: Implements read and writes locks until the transaction is finished. Also implements range locks.
- Repeatable Reads: Implements read and write locks until the transaction is completed. Doesn’t manage range locks.
- Read Committed: Implements write locks until the transaction is completed but releases read locks when a SELECT operation is performed.
- Read Uncommitted: One transaction can see the uncommitted changes made by the other transaction.

### 6. What is the purpose of indexing the database? How do indices operate? Give some examples of guidance rules of indexing.

https://logicalread.com/guidelines-sql-server-indices-mc03/

A database index allows a query to efficiently retrieve data from a database.  Indexes are related to specific tables and consist of one or more keys

### 7. How to ensure high quality of database model and validate a database? Name some validation techniques. Give examples of validation against user transactions?

???????????

### 8. Name some criteria for database operations performance. How to estimate the cost of an operation? Name some techniques for performance optimization. 

Avoid over fetching? - Avoid having to many joins?

### 9. What is called transaction log, what does it contain and how to use it?

A transaction log, records all database modifications. When a user issues an INSERT, for example, it is logged in the transaction log. This enables the database to roll back or restore the transaction if a failure were to occur and prevents data corruption

If the log is well strucuted you can re-create the entire DB if it were to be destroyed.

### 10. Explain the scope of data security and protection. Name some major security threads. Describe approaches and measures of securing a database. Name some hardware methods of data protection.

https://www.quora.com/What-is-the-scope-of-data-security#:~:text=The%20scope%20of%20data%20security%20includes%20defining%20data%20security%20policies,company%20on%20an%20ongoing%20basis. ???

### 11. What is the meaning of the CAP theorem? How does it differ from the ACID rules?

**C** - Consistency: Every read receives the most recent write or an error  
**A** - Availabbility: Every request receives a (non-error) response, without the guarantee that it contains the most recent write  
**P** - Partition Tolerannce: The system continues to operate despite an arbitrary number of messages being dropped (or delayed) by the network between nodes  

Its impossibble to provide more then two of these.  

![CAP](https://i.imgur.com/cqme5Mu.png)
[ref](https://towardsdatascience.com/cap-theorem-and-distributed-database-management-systems-5c2be977950e#:~:text=CAP%20Theorem%20is%20a%20concept,on%20our%20unique%20use%20case).

When a network partition failure happens should we decide to

- Cancel the operation and thus decrease the availability but ensure consistency
- Proceed with the operation and thus provide availability but risk inconsistency

The CAP theorem implies that in the presence of a network partition, one has to choose between consistency and availability. Note that consistency as defined in the CAP theorem is quite different from the consistency guaranteed in ACID database transactions.

**ACID consistency** is all about database rules. If a schema declares that a value must be unique, then a consistent system will enforce uniqueness of that value across all operations.

**CAP consistency** promises that every replica of the same logical value, spread across nodes in a distributed system, has the same exact value at all times.

[ref](https://www.voltdb.com/blog/2015/10/disambiguating-acid-cap/#:~:text=ACID%20consistency%20is%20all%20about%20database%20rules.&text=CAP%20consistency%20promises%20that%20every,exact%20value%20at%20all%20times).


### 12. Explain how to choose an appropriate database type for an application.

(Talk about our project)

## SQL Database

### 13. What is called relational data model? Which are the model’s components? What is the difference between relation and relationship? Which are the properties of a relationship?

### 14. Which mathematical theory staysbehind the relational data models?Which theoretical terms are used for describing the model and its components? 

### 15. What is called relational algebra? How is it related to database development?Which relational operations can be performed in a database? Name some unary and binary operations.

### 16. Which are the main programming units in SQL? Explain the difference between them. What are the advantages of using SQL programming units?

### 17. Which are the stages of database development methodology? Which are their objectives, tasks, tools and techniques?At which stage are the database requirements specified?Which tasks are solved at the design stage?Which are the three design layers?How do they differ?

### 18. What are the purpose and the content of the data dictionary? What are the candidate key, primary key, and composite key. What is the use of them?

### 19. What is the meaning of functional dependency?Explain the implementation of it. Give examples.How does it relate to database normalization?

### 20. What is the purpose of database normalization? Which are the basic normal forms of a relation? What is the purpose of database de-normalization? Give examples for implementation of de-normalization techniques.

### 21. What is referential integrity and why is it important?Give examples of methods for supporting the referential integrity.

### 22. What is the purpose of data locking? Which database resources are lockable? What is called deadlock and how to avoid it?

### 23. Which data is called derived data? What is called database view? What are the advantages and limitationsof using views? Name one advantage of view parametrisation.Name one disadvantage of view materialization.

### 24. Explain how SQL queries are executed by a database server. Explain what is an execution plan, how is it built and used? What is the difference between the estimated and actual execution plans? 

### 25. What are the objectives of query optimisation? How can a developer support it?What are the roles of SARGs and JOINs in query optimization?

### 26. What does ORM stay for? How is it used? Name some ORM programming instruments.What is known as Impedance Mismatch? Which are the mismatches between object data model and relational data model?

### 27. What are the strengths and weaknesses of RDB? When is RDB the best choice of database type and when it should be avoided?Name some typical use cases and applications.

## NoSQL

### 28. What stays behind the abbreviation NoSQL? How have the NoSQL databases originated? Which are the main differences between SQL and NoSQL databases?

### 29. Describe four major types of NoSQL databasesand their appropriate implementations. Name one representative database of each type.

### 30. What typeof a databasesis used for handling large volumes ofunstructured data?

### 31. Name some criteria for comparison the NoSQL databases. How do they compare CAP-wise?

### 32. What is known as Big Data? Which are the basic features of it? Which big data processing technologiesyou are familiar with?

### 33. Explain Map-Reduce concept. Which databases provide support for it? Give an example of implementation.

## Column-Oriented Database

### 34. What type of database is HBase? Which are the main features of itand what is their impact? Which CAP features are supported by HBase?

### 35. How does HBase differ from SQL databases? How does it support transactions and indexing?

### 36. Which is the underlying storage model HBaseuses?Which are the advantages of such a model?

### 37. Explain HBase scalability model. What is the role of HMaster, Region Server, and Zookeeper?

### 38. Which are the available work modes for HBase? How are the read and write operations performed?

### 39. What are the strengths and weaknesses of HBase? When is HBase the best choice of database type and when it should be avoided? Name some typical use cases and applications.

## Document Database

### 40. What type of database is MongoDB? Which data model does it use? How does it differ from RDB? 

MongoDB is a NoSQL database, it works with JSON documents... However if you use a libary called "Mongoose" you can set up schemas to define your collections.

### 41. Which language is MongoDB written in? (Javascript, C, C++)

[ref](https://en.wikipedia.org/wiki/MongoDB)

MongoDB (from humongous) is a cross-platform document-oriented database. "JS, C and C++"

### 42. Is MongoDB classified as a NoSQL database?

Yes

### 43. Which format is supported by MongoDB? (SQL, XML and/or BSON)

MongoDB avoids the traditional table-based relational database structure in favor of JSON-like documents with dynamic schemas.

(JSON/BSON)

### 44. Is MongoDB a graph, key value and/or a document database that provides high performance,high availability, and easy scalability?

Document-based

### 45. How does MongoDB provide high availability?

MongoDB is a CP-database and uses *shards* to ensure high availability.

![Shard](https://i.imgur.com/Q5w8ZFC.png)

### 46. Can MongoDB be used as a file system? Can MongoDB run over single servers only?

MongoDB can run over multiple servers, balancing the load and/or duplicating data to keep the system up and running in case of hardware failure.

"yes to both"

### 47. When MongoDB scales horizontally using sharding for load balancing purpose, who chooses the shard key, which determines how the data in a collection will be distributed?

[ref](https://hub.packtpub.com/mongodb-sharding-clusters-choosing-right-shard-key/#:~:text=The%20primary%20shard%20is%20different,at%20the%20moment%20of%20creation.)

The primary shard is automatically selected by MongoDB when we create a new database in a sharded environment. MongoDB will pick the shard that has the least data stored at the moment of creation.

"The user (developer) chooses a shard key, which determines how the data in a collection will be distributed"

### 48. Is it correct that the primary replica performs all writes and reads by default?

[ref](https://docs.mongodb.com/manual/core/replica-set-primary/)

Yes, by default. However all members of the replica set can accept read operationns.

*note:* the primary is the only member in the replica set that receives **write** operations

![Replica Set](https://i.imgur.com/raD6Jen.png)

### 49. Is it correct that data in MongoDB has a flexible schema?

[ref](https://docs.mongodb.com/manual/data-modeling/)

Yes.

Data in MongoDB has a flexible schema. Collections do not enforce document structure by default. This flexibility gives you data-modeling choices to match your application and its performance requirements.

### 50. In MongoDB, at which level are write operations atomic?

[ref](https://docs.mongodb.com/manual/core/write-operations-atomicity/)

In MongoDB, a write operation is atomic on the level of a single document, even if the operation modifies multiple embedded documents within a single document.

### 51. Explain how MongoDB processes collection of documents using Map-Reduce operations. Explain the phases in MongoDB’s Map-Reduce.What would be the maximum document size for results of Map-Reduce operation?

TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO TODO

### 52. How does MongoDB support transaction management?

[ref](https://docs.mongodb.com/manual/core/transactions/)

In MongoDB, an operation on a single document is atomic. Because you can use embedded documents and arrays to capture relationships between data in a single document structure instead of normalizing across multiple documents and collections, this single-document atomicity obviates the need for multi-document transactions for many practical use cases.

MongoDB supports multi-document transactions. With distributed transactions, transactions can be used across multiple operations, collections, databases, documents, and shards.

*In short*, On single documents Mongo is atomic by nature - however when theres multiple collectionsn you'll need to use multi-document transactions.

### 53. How do indexes support the efficient execution of queries in MongoDB? What are the consequences of adding an index in MongoDB?

Without indexes, MongoDB must perform a collection scan

the query performance gain that we get with indexes doesn’t come for free. With each additional index, we decrease our write speed for a collection.

[ref](https://www.quora.com/What-are-pros-and-cons-of-creating-indexes-in-MongoDB)

### 54. Which index is unique and prevents clients from inserting two documents with the same value for the _id field?

The _id field

All MongoDB collections have an index on the _id field that exists by default.

### 55. Which index type provided by MongoDB supports searching for string content in a collection: string, text or char?

Text

MongoDB provides a text index type that supports searching for string content in a collection. These text indexes do not store language-specific stop words (e.g. “the”, “a”, “or”) and stem the words in a collection to only store root words.

[ref](https://docs.mongodb.com/manual/indexes/)

### 56. Can MongoDB return sorted results by using the ordering in the index?

Yes.

Indexes are special data structures that store a small portion of the collection’s data set in an easy to traverse form.

### 57. Which operation adds a new document to the user’s collection?

db.collection.insert({...})

### 58. Which operator is similar to ORDER BY clause in RDBMS?

db.collection.find().sort({...})

In addition you can aslo use the *$orderby*

### 59. How can you limit the number of documents in result set? How is COUNT function provided in MongoDB?

db.collection.find(*query*).limit(*number*)

db.collection.count() method does not perform the find() operation but instead counts and returns the number of results that match a query.

### 60. What are the strengths and weaknesses of MongoDB? When is MongoDB the best choice of database type and when it should be avoided? Name some typical use cases and applications.

[ref](http://alronz.github.io/Factors-Influencing-NoSQL-Adoption/site/MongoDB/Results/Strengths%20and%20Weaknesses/)


**Strengths**
- Easy to scale
- Flexible document data model 
- Replication and high availability
- Rich query cappabilities

**Weaknesses**
- Not reccomended for relational data
- No internal transaction suppport

Mongo is very suitable for tasks such as logginng and content management. Mongo isn't an ideal database for application that has data with a relational nature (Social Platforms).

MongoDB excels on applications that requires efficient horizontal scaling, high availability and flexible data model that makes developer's life more easy and at the same time having a data suitable for the document data model.


## Graph-Oriented Database

### 61. What type of database Neo4j is? Which data model it is built on? How does it differ from the relational model? Which types of operations with data does it support?

### 62. Which is the underlying storage model of Neo4j database? Which advantages does it provide?

### 63. Which are the components of Neo4j development platform? Which connectivity methods are available? Which are the main libraries, extending the core functionality of Neo4j?

### 64. How does Neo4j respond to ACID and CAP? How does clustering relate to ACID and CAP features? Which cluster architectures are available for Neo4j?

### 65. How does Neo4j support transactions and indexing? How do read and write operations differ when executed in a cluster?

### 66. Which query language is used for processing the graph data? Which are the objects It operates with?

### 67. Which categories of graph algorithms are enabled in Neo4j? What is their implementation? Give some examples of algorithms in each category. Give some examples of business cases, which benefit from the implementation of graph algorithms.

### 68. What are the strengths and weaknesses of Neo4j? When is Neo4j the best choice of database type and when it should be avoided? Name some typical use cases and applications.

## Key-Value Data Store

### 69. What type of database is Redis? Which data model does it use? How does it differ from RDB?

### 70. Explain the Replication feature of Redis?

### 71. List out the operation keys of Redis.

### 72. Does Redis give speed and durability both?

### 73. How can you improve the durability in Redis?

### 74. Mention what are the things you have to take care while using Redis?

### 75. What are the strengths and weaknesses of Redis? When is Redis the best choice of database type and when it should be avoided? Name some typical use cases and applications.