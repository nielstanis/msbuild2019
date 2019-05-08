#!/bin/bash
rm -rf ../Published/MyPDFLibrary
dotnet publish -c Debug -r osx-x64 -o ../Published/MyPDFLibrary --self-contained
