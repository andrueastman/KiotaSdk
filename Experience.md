## Batch
### Graph v4
```cs
BatchRequestContent batchRequestContent = new BatchRequestContent();

IUserRequest usersRequest = graphClient.Users.Request();
batchRequestContent.AddBatchRequestStep(usersRequest);
usersRequest.Method = HttpMethods.DELETE;// Modify the request object to change its properties

BatchResponseContent batchResponse = await graphClient.Batch.Request().PostAsync(batchRequestContent);
```

### Graph Kiota
```cs
BatchRequestContent batchRequestContent = new BatchRequestContent(graphClient);

RequestInformation getUsersRequestInfo = graphClient.Users["user-id"].CreateDeleteRequestInformation();
batchRequestContent.AddBatchRequestStep(getUsersRequestInfo);

BatchResponseContent batchResponse = await graphClient.Batch.PostAsync(batchRequestContent);
```












## PageIterator

### Graph v4
```cs
List<User> userList = new List<User>();
var itemCallback = (User user) => {
    userList.Add(user);
    return true;
};

var requestConfigurator = (IBaseRequest request) =>
{
    request.Method = HttpMethods.GET;
    return request;
};

var pageIterator = eventPageIterator = PageIterator<User>.CreatePageIterator(graphClient, users, itemCallback, requestConfigurator);

await eventPageIterator.IterateAsync();
```

### Graph Kiota
```cs
List<User> userList = new List<User>();
var itemCallback = (User user) => {
    userList.Add(user);
    return true;
};

var requestConfigurator = (RequestInformation request) =>
{
    request.HttpMethod = HttpMethod.GET;
    return request;
};

var pageIterator = PageIterator<User,UsersResponse>.CreatePageIterator(graphClient, users, itemCallback, requestConfigurator);

await pageIterator.IterateAsync();
```