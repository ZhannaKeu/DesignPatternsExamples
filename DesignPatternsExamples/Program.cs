// See https://aka.ms/new-console-template for more information

using DesignPatternsExamples.Addapter_pattern;
using DesignPatternsExamples.Composite_pattern;
using DesignPatternsExamples.Decorator_pattern;

// Adapter pattern example
string webHost = "Host: https://google.com\n\r";
WebService service=new WebService(webHost);
WebAdapter adapter = new WebAdapter();
adapter.Connect(service);
WebClient client=new WebClient(adapter);
client.DoWork();

// Composite pattern example
Housing building = new Housing("123 Street");
Housing floor1 = new Housing("123 Streest - First floor");
int firstFloor = building.AddStructure(floor1);

Room washroom1m = new Room("1F Men's Washroom");
Room washroom1w = new Room("1F Women's Washroom");
Room common1 = new Room("1F Common Area");

int firstMens = floor1.AddStructure(washroom1m);
int firstWomens = floor1.AddStructure(washroom1w);
int firstCommon = floor1.AddStructure(common1);

building.Enter();
Housing currentFloor = (Housing)building.GetStructure(firstFloor);
currentFloor.Enter();
Room currentRoom = (Room)currentFloor.GetStructure(firstMens);
currentRoom.Enter();
currentRoom = (Room)currentFloor.GetStructure(firstCommon);
currentRoom.Enter();

// Decorator pattern example
IWebPage myPage = new BasicWebPage();
myPage = new AuthorizedWebPage(myPage);
myPage = new AuthenticatedWebPage(myPage);
myPage.Display();
