--
-- PostgreSQL database dump
--

-- Dumped from database version 11.4
-- Dumped by pg_dump version 11.5

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: FoodItem; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."FoodItem" (
    "Id" uuid NOT NULL,
    "Name" character varying NOT NULL,
    "Price" numeric NOT NULL,
    "Description" character varying,
    "Ingredients" character varying NOT NULL
);


ALTER TABLE public."FoodItem" OWNER TO postgres;

--
-- Name: FoodItemCategory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."FoodItemCategory" (
    "Id" uuid NOT NULL,
    "Name" character varying NOT NULL,
    "SortOrder" numeric NOT NULL
);


ALTER TABLE public."FoodItemCategory" OWNER TO postgres;

--
-- Data for Name: FoodItem; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."FoodItem" ("Id", "Name", "Price", "Description", "Ingredients") FROM stdin;
4d04d700-6286-439d-9de8-ee07295b35a4	asd	1234	dfda	asdfa
eaa31bed-d9b8-46c6-83c2-ad39030b3c44	adas	12	asdas	asd
\.


--
-- Data for Name: FoodItemCategory; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."FoodItemCategory" ("Id", "Name", "SortOrder") FROM stdin;
02f9cb0d-9fd2-4e44-b4ee-799ea40a22da	asdadf	10
eef0b33d-56e8-4411-8f4b-88356a10e1c4	dgdag	1
\.


--
-- Name: FoodItemCategory FoodItemCategory_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."FoodItemCategory"
    ADD CONSTRAINT "FoodItemCategory_pkey" PRIMARY KEY ("Id");


--
-- Name: FoodItem FoodItem_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."FoodItem"
    ADD CONSTRAINT "FoodItem_pkey" PRIMARY KEY ("Id");


--
-- PostgreSQL database dump complete
--

