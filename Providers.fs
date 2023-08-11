namespace XmlProviderXsdDupes

open FSharp.Data

module Providers =
  [<Literal>]
  let private schemaRoot = __SOURCE_DIRECTORY__

  type DupeProvider = XmlProvider<Schema="sample.xsd", ResolutionFolder=schemaRoot, Global=true>