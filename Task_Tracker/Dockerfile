FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
# copy files from host(./bin...  .=>> working dirctory that conatin dockerfile) to image(. ==> /app)
COPY ./bin/Debug/net8.0/ .
ENTRYPOINT ["dotnet", "Task_Tracker.dll"]