using TrackingSystemForTrucksDispatched;
using Microsoft.EntityFrameworkCore;

var db = new TruckDispatchDbContext();
Helpers.SeedData(db);
var dispatches = Helpers.GetAll(db);
Helpers.Print(dispatches);
db.Dispose();
