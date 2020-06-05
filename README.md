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

![](https://imgur.com/a/JLJQ0sj)

### 4. What is called a database transaction? Which are the main properties of a transaction? Explain ACID properties.

### 5. Explain the concurrency problem in database implementation and the techniques for controlling it. How does it relate to transaction management and isolation? Which are the basic transaction isolation levels? 

### 6. What is the purpose of indexing thedatabase? How do indicesoperate? Give some examples of guidance rules of indexing.

### 7. How to ensure high quality of database model and validate a database? Name some validation techniques. Give examples of validation against user transactions?

### 8. Name some criteria for database operations performance. How to estimate the cost of an operation? Name some techniques for performance optimization. 

### 9. What is called transaction log, what does it contain and how to use it?

### 10. Explain the scope of data securityand protection. Name some major security threads. Describe approaches and measures of securing a database. Name some hardware methods of data protection.

### 11. What is the meaning of the CAP theorem? How does it differ from the ACID rules?

### 12. Explain how to choosean appropriate database type for an application.

## SQL Database

### 13. What is called relational data model? Which are the model’s components?What is the difference between relation and relationship? Which are the properties of a relationship?

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

### 41. Which language is MongoDB written in? (Javascript, C, C++)

### 42. Is MongoDB classified as a NoSQL database?

### 43. Which format is supported by MongoDB? (SQL, XML and/or BSON)

### 44. Is MongoDB a graph, key value and/or a document database that provides high performance,high availability, and easy scalability?

### 45. How does MongoDB provide high availability?

### 46. Can MongoDB beused as a file system? Can MongoDB run over single servers only?

### 47. When MongoDB scales horizontally using sharding for load balancing purpose, who choosesthe shard key, which determines how the data in a collection will be distributed?

### 48. Is it correct that the primary replica performs all writes and reads by default?

### 49. Is it correct that data in MongoDB has a flexible schema?

### 50. In MongoDB, at which level are write operations atomic?

### 51. Explain how MongoDB processescollection of documents using Map-Reduce operations.Explain the phases in MongoDB’s Map-Reduce.What would be the maximum document size for results of Map-Reduce operation?

### 52. How does MongoDB support transaction management?

### 53. How doindexes support the efficient execution of queries in MongoDB?What are the consequencesof adding an index in MongoDB?

### 54. Which index is unique and prevents clients from inserting two documents with the samevalue for the _id field?

### 55. Which index type provided byMongoDB supports searching for string content in acollection: string, text or char?

### 56. Can MongoDB return sorted results by using the ordering in the index?

### 57. Which operation adds a new document to the user’s collection?

### 58. Which operator is similar to ORDER BYclause in RDBMS?

### 59. How can you limit the number of documents in result set?How is COUNT function provided in MongoDB?

### 60. What are the strengths and weaknesses of MongoDB? When is MongoDB the best choice of database type and when it should be avoided? Name some typical use cases and applications.

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