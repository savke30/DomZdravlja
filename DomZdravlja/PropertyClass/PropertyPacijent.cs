﻿using DomZdravlja.AttributeClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomZdravlja.PropertyClass
{
    public class PropertyPacijent:PropertyInterface
    {
        #region Atributi
        private int pacijentID;
        private int doktorID;
        private int osobaID;
        private int osiguran;
        #endregion

        #region Property

        [DisplayName("Šifra pacijenta")]
        [SqlName("PacijentID")]
        [GenerateComponent(ComponentType.Tekst)]
        [PrimaryKey]
        [Invisible(Use.Insert)]
        public int PacijentID
        {
            get
            {
                return pacijentID;
            }
            set
            {
                pacijentID = value;
            }
        }

        [DisplayName("Šifra doktora")]
        [SqlName("DoktorID")]
        [GenerateComponent(ComponentType.Lookup)]
        [ForeignKey("DomZdravlja.PropertyClass.PropertyZaposleni", "Šifra doktora", Tip.Doktori, "Ime", "Prezime", false)]
        [ValidatePattern(@"^\d+$")]
        [Editing(Use.InsertAndUpdate)]
        public int DoktorID
        {
            get
            {
                return doktorID;
            }
            set
            {
                doktorID = value;
            }
        }

        [DisplayName("Šifra osobe")]
        [SqlName("OsobaID")]
        [GenerateComponent(ComponentType.InsertLookup)]
        [ForeignKey("DomZdravlja.PropertyClass.PropertyOsoba", "Šifra osobe", Tip.Osoba, "Ime", "Prezime", true)]
        [ValidatePattern(@"^\d+$")]
        [MainSearch(null)]
        [Editing(Use.InsertAndUpdate)]
        public int OsobaID
        {
            get
            {
                return osobaID;
            }
            set
            {
                osobaID = value;
            }
        }

        [DisplayName("Osiguran")]
        [SqlName("Osiguran")]
        [GenerateComponent(ComponentType.RadioButton)]
        [OpcijeRadioButton("Da", "Ne", 1, 0)]
        [ValidatePattern(@"^\d+$")]
        [Editing(Use.InsertAndUpdate)]
        public int Osiguran
        {
            get
            {
                return osiguran;
            }
            set
            {
                osiguran = value;
            }
        }
        #endregion

        #region Querys

        public string GetDeleteQuery()
        {
            return @"
                    DELETE FROM [dbo].[Pacijent]
                          WHERE PacijentID = @PacijentID
                    ";
        }

        public string GetInsertQuery()
        {
            return @"
                    INSERT INTO [dbo].[Pacijent]
                               ([DoktorID]
                               ,[OsobaID]
                               ,[Osiguran])
                         VALUES
                               (@DoktorID
                               ,@OsobaID
                               ,@Osiguran)
                    ";
        }

        public string GetSelectQuery()
        {
            return @"
                  
                    SELECT [PacijentID]
                          ,[DoktorID]
                          ,[OsobaID]
                          ,[Osiguran]
                      FROM [dbo].[Pacijent]
                    ";
        }

        public string GetUpdateQuery()
        {
            return @"
                    UPDATE [dbo].[Pacijent]
                       SET [DoktorID] = @DoktorID
                          ,[OsobaID] = @OsobaID
                          ,[Osiguran] = @Osiguran
                     WHERE PacijentID = @PacijentID
                    ";
        }

        #endregion

        #region Parametri

        public List<SqlParameter> GetDeleteParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();

            SqlParameter PacijentID = new SqlParameter("@PacijentID", System.Data.SqlDbType.Int);
            PacijentID.Value = pacijentID;
            list.Add(PacijentID);

            return list;
        }

        public List<SqlParameter> GetInsertParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();

            SqlParameter DoktorID = new SqlParameter("@DoktorID", System.Data.SqlDbType.Int);
            DoktorID.Value = doktorID;
            list.Add(DoktorID);

            SqlParameter OsobaID = new SqlParameter("@OsobaID", System.Data.SqlDbType.Int);
            OsobaID.Value = osobaID;
            list.Add(OsobaID);

            SqlParameter Osiguran = new SqlParameter("@Osiguran", System.Data.SqlDbType.TinyInt);
            Osiguran.Value = osiguran;
            list.Add(Osiguran);

            return list;
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> list = new List<SqlParameter>();

            SqlParameter PacijentID = new SqlParameter("@PacijentID", System.Data.SqlDbType.Int);
            PacijentID.Value = pacijentID;
            list.Add(PacijentID);

            SqlParameter DoktorID = new SqlParameter("@DoktorID", System.Data.SqlDbType.Int);
            DoktorID.Value = doktorID;
            list.Add(DoktorID);

            SqlParameter OsobaID = new SqlParameter("@OsobaID", System.Data.SqlDbType.Int);
            OsobaID.Value = osobaID;
            list.Add(OsobaID);

            SqlParameter Osiguran = new SqlParameter("@Osiguran", System.Data.SqlDbType.TinyInt);
            Osiguran.Value = osiguran;
            list.Add(Osiguran);

            return list;
        }

        #endregion

    }
}
