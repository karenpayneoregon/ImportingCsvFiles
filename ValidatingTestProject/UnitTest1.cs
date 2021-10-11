﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using Operations;
using ValidatingTestProject.Base;
using static ValidatingTestProject.Base.Trait;

namespace ValidatingTestProject
{
    [TestClass]
    public partial class UnitTest1 : TestBase
    {
        [TestMethod]
        [TestTraits(FileOperation)]
        public void EmptyLineCountTest()
        {
            var emptyLineCount = 0;

            int totalLineCount = 0;
            using (var reader = File.OpenText(_inputFileName))
            {
                var line = "";

                while ((line = reader.ReadLine()) != null) // EOF
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        emptyLineCount++;
                    }

                    totalLineCount += 1;
                }
            }

            Assert.AreEqual(emptyLineCount, 2);
            Assert.AreEqual(totalLineCount, 7586);

        }

        [TestMethod]
        [TestTraits(FileOperation)]
        public void FieldCountTest()
        {
            var invalidRows = new List<DataItemInvalid>();
            var index = 1;
            var validateBad = 0;


            using (var parser = new TextFieldParser(_inputFileName))
            {
                parser.Delimiters = new[] { "," };

                while (true)
                {
                    string[] parts = parser.ReadFields();

                    if (parts == null)
                    {
                        break;
                    }

                    index += 1;

                    if (parts.Length != 9)
                    {

                        invalidRows.Add(new DataItemInvalid()
                        {
                            Row = index,
                            Line = string.Join(",", parts)
                        });

                        continue;

                    }

                    if (index <= 1) continue;
                }

            }

            Assert.AreEqual(invalidRows.Count, 2);

            Assert.IsTrue(invalidRows[0].Line.Contains("10851(A)VC TAKE VEH W/O OWNER"));
            Assert.IsTrue(invalidRows[1].Line.Contains("1857 DISCOVERY WAY"));

        }

        /// <summary>
        /// Validate fields
        /// We could break this down for each validation/assertion
        /// </summary>
        [TestMethod]
        [TestTraits(FileOperation)]
        public void QuestionableFieldsTest()
        {

            var index = 1;
            var validateBad = 0;
            int district = 0;
            int grid = 0;
            int ucrNcicCode = 0;
            float latitude = 0;
            float longitude = 0;

            var validRows = new List<DataItem>();
            var invalidRows = new List<DataItemInvalid>();


            using (var parser = new TextFieldParser(_inputFileName))
            {
                parser.Delimiters = new[] { "," };

                while (true)
                {
                    string[] parts = parser.ReadFields();

                    if (parts == null)
                    {
                        break;
                    }

                    index += 1;



                    if (index <= 1) continue;


                    if (parts.Length == 9)
                    {
                        var validRow =
                            DateTime.TryParse(parts[0], out var cdatetime) &&
                            float.TryParse(parts[7].Trim(), out latitude) &&
                            float.TryParse(parts[8].Trim(), out longitude) &&
                            int.TryParse(parts[2], out district) &&
                            int.TryParse(parts[4], out grid) &&
                            !string.IsNullOrWhiteSpace(parts[5]) &&
                            int.TryParse(parts[6], out ucrNcicCode);

                        if (string.IsNullOrWhiteSpace(parts[1]))
                        {
                            validateBad += 1;
                        }

                        if (string.IsNullOrWhiteSpace(parts[3]))
                        {
                            validateBad += 1;
                        }

                        // NICI code must be 909 or greater
                        if (ucrNcicCode < 909)
                        {
                            validateBad += 1;
                        }

                        if (validRow)
                        {

                            validRows.Add(new DataItem()
                            {
                                Id = index,
                                Date = cdatetime,
                                Address = parts[1],
                                District = district,
                                Beat = parts[3],
                                Grid = grid,
                                Description = parts[5],
                                NcicCode = ucrNcicCode,
                                Latitude = latitude,
                                Longitude = longitude,
                                Inspect = validateBad > 0
                            });

                        }
                        else
                        {
                            // fields to review in specific rows
                            invalidRows.Add(new DataItemInvalid()
                            {
                                Row = index,
                                Line = string.Join(",", parts)
                            });
                        }
                    }




                }

            }

            Assert.AreEqual(validateBad, 44);
            Assert.AreEqual(district,4);
            Assert.AreEqual(validRows.Count,7580);
            Assert.AreEqual(invalidRows.Count, 2);


        }




    }
}
