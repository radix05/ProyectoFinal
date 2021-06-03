<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarPresentacion.aspx.cs" Inherits="ProyectoParaExamenQuintoSemestre.AgregarPresentacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://pro.fontawesome.com/releases/v5.10.0/css/all.css" integrity="sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p" crossorigin="anonymous" />
    <script src="https://code.jquery.com/jquery-3.5.1.min.js" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

</head>
<body>
    <style>
        .contenedor-divs {
            width: 100%;
            height: 100vh;
            display: grid;
            width: 100%;
            text-align: center;
        }

        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: Arial;
        }

        h1 {
            font-family: Arial;
            font-size: 2.5rem;
            text-transform: uppercase;
        }

        p {
            font-family: Arial;
            font-size: 1rem;
            text-transform: uppercase;
            line-height: 1rem;
        }

        .Presentacion {
            height: 90vh;
            background: rgba(0,0,0,.1);
        }

        .links {
            height: 10vh;
            width: 100%;
            background: rgba(0,0,0,.1);
        }



        .link {
            float: left;
            border-radius: 25px;
            text-decoration: none;
            color: #fff;
            background: #333333;
            font-size: 1rem;
            font-family: Arial;
            padding: 5px 10px !important;
            cursor: pointer;
        }

        .titulo {
            margin-top:10vh;
            background: #333333;
            color: #fff;
        }

        .Desc {
            width: 60%;
            border: 1px solid #333333;
            margin-left: 20%;
            margin-top: 3vh;
            padding: 5px 10px;
        }
    </style>
    <form id="form1" runat="server">
        <asp:Panel runat="server" ID="pnlGenerar"></asp:Panel>


    </form>
    <script>

        $('.contenedor-divs').hide();
        $('#S1').show('slow');

        $('.link').click(function () {
            var siguiente = $(this).attr("siguiente");
            var actual = $(this).attr("actual");

            $('#S' + actual).hide('slow');
            $('#S' + siguiente).show('slow');
        });
    </script>
</body>
</html>
