# Exercise Sheet MongoDB

## Setup and getting ready:

With Mongo installed, import both datafiles with the following commannds:

```bash
mongoimport --db earth --collection countries --drop --file data/countries-big.json

mongorestore --db twitter --collection tweet data/tweets.bson
```

NOTE:

- mongodump - mongorestore work on BSON file formats.
  creates the dump of full database system in one go.
- mongoexport - mongoimport work on JSON , CSV , TSV files.
  creates data dump on per collection basis.

## Exercise: Sharding in MongoDB

What is sharding in mongoDB?
What are the different components required to implement sharding?
Explain architecture of sharding in mongoDB?

## Exercise: MapReduce with mongoDB // DATASET MISSING SKIPPING

As a first exercise you are required to load the reddit dataset. With help of map and reduce you need to find top 10 “lang” (language) of the documents in reddit.

a) Provide implementation of map and reduce function
b) Provide execution command for running MapReduce
c) Provide top 10 recorded out of the sorted result. (hint: use sort on the result returned by MapReduce)

## MapReduce with mongoDB (hashtag query)

For this task you need to download the twitter dataset. This time you have to answer query “what are the top 10 hashtags used in the given tweets”. To answer this you need to use MapReduce. You can look at the scheme of the collection using `db.collection.findOne()`. It will print one record with scheme information.

Also you can use function like `this.hasOwnProperty(‘field_name’)` to check if a field exist in the record. (if the field does not exist you will get error).

a) Provide implementation of map and reduce function
b) Provide execution command for running MapReduce
c) Provide top 10 recorded out of the sorted result. (hint: use sort on the result returned by
MapReduce)
