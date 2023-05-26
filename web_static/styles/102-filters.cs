.filters {
  background-color: white;
  height: 70px;
  width: 100%;
  border: 1px solid #dddddd;
  border-radius: 4px;
  display: flex;
  justify-content: flex-end;
  align-items: center;
}

.filters button {
  font-size: 18px;
  background-color: #ff5a5f;
  color: #ffffff;
  height: 48px;
  width: 20%;
  border: none;
  border-radius: 4px;
  margin-left: auto;
  margin-right: 30px;
}

.filters button:hover {
  opacity: 0.9;
}

.filters .locations {
  border-right: #dddddd solid 1px;
}

.filters .locations,
.filters .amenities {
  height: 100%;
  width: 25%;
  position: relative;
  z-index: 1;
}

.filters .locations h3,
.filters .amenities h3 {
  font-weight: 600;
  margin: 0;
  padding: 17px 30px 0 30px;
}

.filters .locations h4,
.filters .amenities h4 {
  font-weight: 400;
  font-size: 14px;
  margin-top: 0;
  padding-left: 30px;
}

.popover h2 {
  font-size: 16px;
  margin: 0;
  padding: 10px 0px 0px 30px;
}

.popover {
  background: #FAFAFA;
  border: 1px solid #DDDDDD;
  border-radius: 4px;
  display: none;
  position: absolute;
  padding: 0;
  margin: 0;
  width: 100%;
}

.filters .locations:hover .popover,
.filters .amenities:hover .popover {
  display: block;
}

.filters ul {
  list-style: none;
  margin: 0;
}

.popover li {
  margin: 12px;
}
