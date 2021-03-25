<%@page import="java.util.Locale"%>
<%@page import="com.mk.web.dto.Product"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<jsp:useBean id="productDAO" class="com.mk.web.dao.ProductRepo" scope="session" />

<%
	String id = request.getParameter("id");
	Product product = productDAO.getProductById(id);
	Locale locale = new Locale("ko", "KR");
	int price = product.getUnitPrice();
	String strPrice = locale.getCountry() + " " + String.format(Locale.KOREAN, "%,d", price);
%>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
<title><%=product.getPname() %> Details</title>
</head>
<body>
	<jsp:include page="menu.jsp" />
	
	<div class="jumbotron">
		<div class="container">
			<h1 class="display-3"><%=product.getPname() %></h1>
		</div>
	</div>
	
	<div class="container">
		<div class="row">
			<div class="col-md-6">
				<p><%=product.getDescription() %>
				<p><b>Product Code : </b> <span class="badge badge-danger"><%=product.getProductId() %></span> 
				<p><b>Manufacturer : </b><%=product.getManufacturer() %> 
				<p><b>Category : </b><%=product.getCategory() %> 
				<p><b>Stock : </b><%=product.getUnitInStock() %> 
				<h4><%=strPrice %> ￦</h4>
				<hr>
				<p><a href="#" class="btn btn-info">Product Order &raquo;</a>
				   <a href="products.jsp" class="btn btn-secondary">Product List &raquo;</a>
			</div>
		</div>
	</div>
	<jsp:include page="footer.jsp" />
</body>
</html>