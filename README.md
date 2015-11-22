# Hadoop-MapReduce-Example
Summarizing survey results by IP Address

This mapreduce job processes the input.txt file.  Each line of this file contains an IP address, an id (ex. 10001) corresponding to a survey question, and a value between 1 and 10 signifying their feedback on a survey.

The map part will only processes lines for a given question id and then simulate resolving the given IP address to a country and return the country name and the survey value between 1 and 10.

The reduce part will count the number of responders for each country, add up their results and return the average.  So for example, if 10 people from the United States take the survey and give a summed rating of 80, the job will return "United States, 8"

To get this to work you will need to install HDInsight Emulator:

https://www.microsoft.com/web/gallery/install.aspx?appid=HDINSIGHT

Here's a summary of the commands that need to be entered in the Hadoop command line to process this:

- Create folder to store input
 -  hadoop fs -mkdir /user/
 -   hadoop fs -mkdir /user/[current login user]
 -  hadoop fs -mkdir /user/[current login user]/Input
 -  hadoop fs -mkdir /user/[current login user]/Input/avgreview

- Copy input.txt file to (or whatever the similar path is on your machine)
  C:\hdp\hadoop-2.4.0.2.1.3.0-1981

- Copy input.txt file to Input/avgreview
 -  hadoop fs -put input.txt /user/[current login user]/Input/avgreview

- Confirm data is in directory
 -  hadoop fs -ls /user/[current login user]/Input/avgreview

- Run app from Visual Studio

- View results
 - hadoop fs -cat /user/[current login user]/Output/avgreview/*
