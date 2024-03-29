﻿using Ardalis.Specification;
using Movies.Domain.PretplataContext.KorisnikAgregate;

namespace Movies.Domain.ToDoContext.ContributorAggregate.Specifications;

public class KorisnikByIdSpec : Specification<Korisnik>, ISingleResultSpecification
{
  public KorisnikByIdSpec(int korisnikId)
  {
    Query
        .Where(korisnik => korisnik.Id == korisnikId);
  }
}
