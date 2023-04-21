namespace Application.Features.Products.GetAll;

public sealed record GetAllProductResponse(Guid Id, string Name, string Description, double Price);