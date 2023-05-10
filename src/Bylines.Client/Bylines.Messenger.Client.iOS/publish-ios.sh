#!/bin/bash
dotnet publish -f net7.0-ios -c Release -p:ArchiveOnBuild=true -p:RuntimeIdentifier=ios-arm64
