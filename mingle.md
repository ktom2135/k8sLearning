docker exec mingle tar Ccf $(dirname mingle) - $(basename mingle) | tar Cxf DEST_PATH -


docker cp . |- mingle:mingle

./MingleServer --mingle.dataDir=/mingle/data/ start

./MingleServer --mingle.dataDir=/mingle_data start-launchd

8u212-zulu-centos

export JAVA_HOME=/usr/lib/jvm/jre-1.8.0-openjdk

docker run --rm -it mcr.microsoft.com/java/jdk:8u212-zulu-centos


curl https://mingle-installers.s3.us-west-1.amazonaws.com/19_1/mingle_unix_19_1_e810577.tar.gz -o /mingle.tar.gz

tar -xvzf mingle.tar.gz

https://www.digitalocean.com/community/tutorials/how-to-install-java-on-centos-and-fedora

wget --no-cookies --no-check-certificate --header "Cookie: gpw_e24=http%3A%2F%2Fwww.oracle.com%2F; oraclelicense=accept-securebackup-cookie" "https://download.oracle.com/otn/java/jdk/8u211-b12/478a62b7d4e34b78b671c754eaaf38ab/jre-8u211-linux-x64.rpm?AuthParam=1559231967_f640037b819b4cb64502ee3bfb476784"

rename
mv file1 file2

