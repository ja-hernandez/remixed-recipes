from microsoft/dotnet:latest

copy ./entrypoint.sh /
run sed -i 's/\r//' /entrypoint.sh
run chmod +x /entrypoint.sh

workdir /app

cmd /entrypoint.sh