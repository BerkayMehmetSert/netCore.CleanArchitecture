namespace Application.Features.Products.Create;

public sealed record CreateProductResponse(Guid Id, string Name, string Description, double Price);