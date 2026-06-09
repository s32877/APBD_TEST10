using Microsoft.EntityFrameworkCore;
using PrepT2.Data;

namespace PrepT2.Services;

public class DbService(AppDbContext appDbContext) : IDbService
{
}