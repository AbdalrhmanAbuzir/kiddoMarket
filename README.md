# Baby Essentials E-Commerce Platform

[![Backend/Frontend](https://img.shields.io/badge/.NET_Core_MVC-8.0-purple.svg)](https://dotnet.microsoft.com/apps/aspnet/mvc)
[![Database](https://img.shields.io/badge/Database-MS_SQL_Server-red.svg)](https://www.microsoft.com/en-us/sql-server)
[![Payment Gateway](https://img.shields.io/badge/Payment_Gateway-Stripe-blueviolet.svg)](https://stripe.com/)
[![ORM](https://img.shields.io/badge/ORM-EF_Core-green.svg)](#)

TinyTots is a comprehensive, production-ready full-stack e-commerce web application dedicated to baby essentials. Built using the **ASP.NET Core MVC** architectural pattern, the platform delivers a secure, seamless, and scalable shopping experience—complete with an integrated dynamic shopping cart, structured order management, and secure real-time online checkout powered by **Stripe**.

---

## Project Objectives

*   **Premium UX for Parents:** Provide a highly responsive, clean, and intuitive interface tailored for busy parents shopping for baby products.
*   **Secure Financial Transactions:** Integrate industry-standard payment gateways to protect client financial details during checkout.
*   **Structured Back-Office:** Equip administrators with comprehensive management tools to update catalogs, track inventories, and fulfill orders efficiently.
*   **Maintainable Architecture:** Leverage the MVC pattern to keep core business logic cleanly separated from the presentation layer.

---

## The Impact & Value of TinyTots

Building a modern e-commerce platform requires handling complex multi-step workflows. TinyTots addresses these production needs by implementing:

*   **Robust Payment Processing:** Utilizing Stripe's secure infrastructure to process credit cards safely without storing sensitive payment data locally.
*   **Reliable Order Lifecycle:** Automated state machine processing that safely transitions items from "Cart" to "Processing" upon dynamic webhook confirmations from Stripe.
*   **Inventory Preservation:** Ensuring quantities sync smoothly post-payment to prevent accidental over-selling.

---

## Key Features

### Customer Shopping Experience
*   **Dynamic Product Catalog:** Filterable categories for clothing, toys, feeding essentials, and nursery decor.
*   **Advanced Shopping Cart:** Full CRUD capabilities directly within the persistent user session.
*   **One-Click Secure Checkout:** Complete checkout flows shifting smoothly to native Stripe layouts.

### Stripe Gateway Integration
*   **Tokenized Processing:** Fully secure payment handling via Stripe API.
*   **Webhook Listener:** Dedicated background handler to receive secure transaction success signals from Stripe to automatically update database order statuses.

### Administrative Control Panel
*   **Inventory Dashboard:** Easily add, edit, or remove baby items, adjust stock counts, and upload product cover imagery.
*   **Order Tracking Console:** Review pending, shipped, paid, or canceled orders instantly.

---

## Technology Stack

*   **Framework:** ASP.NET Core MVC (Model-View-Controller)
*   **Language:** C#
*   **Data Access Layer:** Entity Framework Core (Code-First approach)
*   **Database Engine:** Microsoft SQL Server
*   **Payment Services:** Stripe .NET SDK
*   **Client-Side UI:** Razor Views, HTML5, CSS3, Bootstrap 5, JavaScript / jQuery
