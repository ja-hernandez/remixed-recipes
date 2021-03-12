#!/bin/bash
set -e
dotnet restore
# test the DB connection
until dotnet ef -s RemixedRecipes -p RemixedRecipes database update; do
>&2 echo "DB is starting up"
sleep 1
done
>&2 echo "DB is up - executing command"
dotnet watch -p RemixedRecipes run
