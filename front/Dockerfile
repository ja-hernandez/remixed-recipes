from node:latest

copy ./entrypoint.sh /
run sed -i 's/\r//' /entrypoint.sh
run chmod +x /entrypoint.sh

WORKDIR /app

cmd /entrypoint.sh

