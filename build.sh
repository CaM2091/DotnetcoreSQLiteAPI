#!/usr/bin/env bash

dotnet restore src/ && \
    dotnet build src/ && \
    echo "Now, run the following to start the project: dotnet run -p src/project.json web"