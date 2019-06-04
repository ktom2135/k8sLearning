FROM mcr.microsoft.com/java/jdk:8u212-zulu-centos
EXPOSE 8080

COPY ["mingle_unix_19_1_e810577.tar.gz", "/"]

RUN tar -xvzf mingle_unix_19_1_e810577.tar.gz
RUN rm -f /mingle_unix_19_1_e810577.tar.gz
RUN mkdir /mingle_data
WORKDIR /mingle_19_1

# Use "exec" form so that it runs as PID 1 (useful for graceful shutdown)
CMD ["./MingleServer", "--mingle.dataDir=/mingle_data","start-launchd"]

# docker build -t kedk2135/mingle:v1 .