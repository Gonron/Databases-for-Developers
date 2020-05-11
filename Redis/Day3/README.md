# A6 Redis

Watch the Demo.mp4 to see how the three databases works together

**NOTE**: In the video i show that the redis-cli dosen't get updated - However, it turns out it actually does, You just have to do a `get artist-name:"Michael Lundsgaard"`. This will return a count with how many artists have this name. Which in this project is 1. 

There's still the issue with Neo4J duplicating the relations from artist to band for every update... This i don't know how to fix.
