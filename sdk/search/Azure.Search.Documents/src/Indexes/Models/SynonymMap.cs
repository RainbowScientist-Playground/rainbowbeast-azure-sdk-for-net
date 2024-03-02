﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using Azure.Core;

// suppress the generated type for the property `Format`
[assembly: CodeGenSuppressType("SynonymMapFormat")]
namespace Azure.Search.Documents.Indexes.Models
{
    [CodeGenSuppress(nameof(SynonymMap), typeof(string), typeof(string))]
    public partial class SynonymMap
    {
        private const string DefaultFormat = "solr";

        [CodeGenMember("ETag")]
        private string _etag;

        // TODO: Replace constructor and read-only properties when https://github.com/Azure/autorest.csharp/issues/554 is fixed.

        /// <summary>
        /// Initializes a new instance of the <see cref="SynonymMap"/> class.
        /// </summary>
        /// <param name="name">The name of the synonym map.</param>
        /// <param name="synonyms">
        /// The formatted synonyms string to define.
        /// Because only the "solr" synonym map format is currently supported, these are values delimited by "\n".
        /// </param>
        /// <exception cref="ArgumentException"><paramref name="name"/> or <paramref name="synonyms"/> is an empty string.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> or <paramref name="synonyms"/> is null.</exception>
        public SynonymMap(string name, string synonyms)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string", nameof(name));
            }
            if (synonyms == null)
            {
                throw new ArgumentNullException(nameof(synonyms));
            }
            if (synonyms.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string", nameof(synonyms));
            }

            Name = name;
            Format = DefaultFormat;
            Synonyms = synonyms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynonymMap"/> class.
        /// </summary>
        /// <param name="name">The name of the synonym map.</param>
        /// <param name="reader">
        /// A <see cref="TextReader"/> from which formatted synonyms are read.
        /// Because only the "solr" synonym map format is currently supported, these are values delimited by "\n".
        /// </param>
        /// <exception cref="ArgumentException"><paramref name="name"/> is an empty string.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> or <paramref name="reader"/> is null.</exception>
        public SynonymMap(string name, TextReader reader)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string", nameof(name));
            }
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            Name = name;
            Format = DefaultFormat;
            Synonyms = reader.ReadToEnd();
        }

        /// <summary>
        /// The <see cref="Azure.ETag"/> of the <see cref="SynonymMap"/>.
        /// </summary>
        public ETag? ETag
        {
            get => _etag is null ? (ETag?)null : new ETag(_etag);
            set => _etag = value?.ToString();
        }

        /// <summary> The format of the synonym map. Only the "solr" format is currently supported. </summary>
        internal string Format { get; set; }
    }
}
