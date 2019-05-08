#!/bin/bash
rm -rf ../FavoritePlaces/bin/Debug/netcoreapp2.2/plugins/MyPDFLibrary/
dotnet publish -c Debug -r osx-x64 -o ../FavoritePlaces/bin/Debug/netcoreapp2.2/plugins/MyPDFLibrary --self-contained
