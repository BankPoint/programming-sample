<div>
  <h1 align="center">BP Loans Programming Sample</h1>
    <img
      alt="background"
      src="https://bankpointstaticfiles.z21.web.core.windows.net/images/BankPointHeaderConcepts03.jpg"
    />

</div>

<hr />

# Overview

Welcome, and thanks for your interest in BankPoint!

This repo contains a fictional app called **BP Loans**. The app is going to be used by our client banks to monitor
the status of their loan portfolio. We're really excited to get this thing formally launched as we think there's a lot of need in
the space for a solution like this!!

The product is currently in beta and we're starting to get some feedback from our early customer trials. 

Based on that feedback, the product manager and the QA team have created some development tickets which we need you to work on to get 
the product release schedule back on track.


## Getting started

Clone the git repo locally so you have a local working copy. Each ticket contains the requirements for the work to be done.
As you complete each task, commit your work locally with a comment. Be sure to reference the ticket number (e.g. TASK-001) 
in your commit message so the product manager can keep track of our progress.

Once you've completed all the tasks and committed your work, follow the instructions at the end of this document in the 
`Submitting your solution` section.

Good luck!


## Environment setup

This project will require that you have the following installed locally
 
* .NET 5 SDK
* SQL Server Express (or better)
* git 

The starting database schema can be found in the `build` directory. To create the databse for your work you
can run the following from a windows command prompt

```angular2html
sqlcmd.exe -E -i .\build\sql-migrations.sql
```

## Standards and practices

The development team has standardized on the following third party libraries:

* [Dapper](https://github.com/DapperLib/Dapper) - Lightweight ORM for SQL operations
* [Knockout.js](https://knockoutjs.com/) - JavaScript MVVM library
* [Bootstrap](https://getbootstrap.com/) - CSS styling library

You're not expected to have familiarity with these libraries. The documentation links are provided for your reference,
and examples of library usage can be found in the starting sample code.

Oh, almost forgot to mention this, but the development lead is very particular about dependencies. She doesn't want you
to add any new library dependencies for JavaScript or C#. 

On the JavaScript side you can use any language feature available in the latest stable Chrome release.  

Try to follow the coding and styling conventions that you see in place. That will make it easier for other developers
on the team to work on the same files later.


# Development Tasks

## TASK-001 Improve the loans file upload process

The import screen allows a user to upload a properly formatted date file containing loan information. 
A sample loan data file has been provided at `.\build\loan-data-file.csv` with some test data that the QA group uses. 

The product manager wants the loan customer and branch to be popluated during import. There are separate tables
for Loans, Customers, and Branches, but only the Loans table is currently being populated.

````angular2html
Improve the upload process as follows:

* Update DbService to create individual Customers records for the unique names found in the CustomerName column
* Update DbService to create individual Branches records for the unique BranchCode values found in the data file
* Modify the existing Loans insert logic to properly reference the Customers and BranchName records
* Finally, add CustomerName and BranchName to the loan listing screen
````


## TASK-002 Add paging controls to the loans screen

We received feedback from one our beta customers that too many loans are showing on loan listing page at once. 
They have requested that we add paging controls so that only 25 records are shown on the page at a time.

It looks like the original developer had planned to do this as there are Next and Previous buttons on the screen, but 
they're not working.

```angular2html
Update the loan listing screen to:

* Show 25 records at a time
* Activate the Next and Previous buttons so the user can page through the full loan list, 25 records at a time
* Do not perform a full page refresh when paging. The next page of loan results should be retrieved using JavaScript and the page updated dynamically
* Disable the Next or Previous buttons if there is not a next or previous page of data available, respectively
* All JavaScript for the loan list screen should be included in the existing loanList.js file
```

## TASK-003 Data formatting

Update the loan listing grid to format the currency and date columns as follows

```angular2html
* Principal should show as USD currency (e.g. $123,456.78)
* Maturity Date should show in US short date format (e.g. 12/31/2021)
* All formatting changes should be applied client side. Don't modify the LoanDto class for this ticket
```


## TASK-004 Enable sorting for the loan name and customer name columns

The product manager is concerned that some of our larger clients won't be able to easily find the loans they're
interested in as they may have tens of thousands of loans. She wants the grid on the loan listing page to be sortable.

Let's start with adding sorting for Loan Number and Customer Name. We may need to add this to other columns in the future,
but these two columns should be good enough for now.

```angular2html
Update the loan listing screen to:
 
* Show a sorting indicator on the column header to indicate which column is being sorted and in which order. 
  By default the grid should be sorted by loan number ascending
* Clicking on a sortable column should change the sort order from ascending to descending, or vice-versa
* Only one column should be sortable at a time
* If the currently sorted column is clicked again, then the sort order should be toggled
* Ensure that the paged data on screen honors the updated sort options
```


# Submitting your solution

Once you've completed all the development tasks, and committed your changes to your local git repo 
you can follow these steps to send your changes to the program manager

* Make sure that all of your code changes have been committed. The program manager will be reviewing your code diffs.
* Zip up the entire project directory contents
* Copy the zip file out to the directory provided in the original email that we sent out to you
* Send an email to us to let us know you've submitted your solution. The email address to send to will be in the programming sample invitation email.

We'll be back in touch with you within a business day or two for next steps.

Thanks for your help!

