import React, { Component } from "react";
import { withRouter } from "react-router-dom";
import styled from "styled-components";

import * as CardboardActions from "../../actions/CardboardActions";
import CardboardStore from "../../stores/CardboardStore";

import TableData from "./TableData";
import TableHeader from "./TableHeader";
import Pagination from "../Pagination";

import AddCartonSide from "../AddCartonSide";
import EditCartonSide from "../EditCartonSide";
import AddDailyEntry from "../AddDailyEntry";

import Colours from "../common/colours";
const Overlay = styled.div`
  position: fixed;
  width: 100%;
  height: 100%;
  z-index: 3;
  background-color: rgba(109, 98, 61, 0.25);
`;
const Header = styled.div`
  background: linear-gradient(140deg, #762aec 15%, #05d5ff 70%, #fffca6 95%);
  height: 310px;
  border-bottom: 1px solid rgba(0, 0, 0, 0.5);
  position: relative;
  svg {
	position: absolute;
	bottom: -4px;
	width: 100%;
	height: 100px;
	}
`;
const Container = styled.div`
  position: relative;
  padding: 24px;
  background: ${Colours.white};
  margin-top: -100px;
  border-radius: 6px;
  box-shadow: 0 2px 10px -3px rgba(0, 0, 0, 0.3);
`;
const ButtonContainer =styled.div`
	display: flex;
    flex-wrap: nowrap;
    height: 50px;
    border: 1px solid #f1f1f1;
	div {
		width: 33%;
		background: linear-gradient(0deg, #e9ecef, white 70%);
		border-right: 1px solid #e4e4e4;
		padding: 20px;
		text-align: center;
		cursor: pointer;
		font-weight: bold;
		&:last-of-type {
			width: 34%;
		}
		&:hover {
			background: linear-gradient(0deg, white 70%, #e9ecef);
		}
	}
`;
class CartonTable extends Component {
  constructor(props) {
    super(props);

    this.state = {
      catons: [],
      currentPage: 1,
      totalPages: 0,
      selectedRow: {},
      showAddSide: false,
      showEditSide: false,
      showAddDailyEntry: false
    };

    this.getCartons = this.getCartons.bind(this);
    this.hideAddBar = this.hideAddBar.bind(this);
    this.hideEditBar = this.hideEditBar.bind(this);
    this.hideAddDailyEntryBar = this.hideAddDailyEntryBar.bind(this);

    this.onItemSelected = this.onItemSelected.bind(this);
    this.showAddSide = this.showAddSide.bind(this);
    this.evaluation = this.evaluation.bind(this);
    this.showAddDailyEntry = this.showAddDailyEntry.bind(this);
    this.redirectToLogin = this.redirectToLogin.bind(this);

    // pagination
    this.onPreviousClick = this.onPreviousClick.bind(this);
    this.onPageClick = this.onPageClick.bind(this);
    this.onNextClick = this.onNextClick.bind(this);
    this.getNumOfPages = this.getNumOfPages.bind(this);
  }

  componentWillMount() {
    CardboardStore.on("fetched_cartons", this.getCartons);
    CardboardStore.on("fetched_pages_count", this.getNumOfPages);
    CardboardStore.on("hide_add_bar", this.hideAddBar);
    CardboardStore.on("hide_edit_bar", this.hideEditBar);
    CardboardStore.on("hide_add_daily_entry_bar", this.hideAddDailyEntryBar);
    CardboardStore.on("unauthorized", this.redirectToLogin);
  }

  componentDidMount() {
    CardboardActions.getCartonsPageCount();
    CardboardActions.getCartons(1);
  }

  componentWillUnmount() {
    CardboardStore.removeListener("fetched_cartons", this.getCartons);
    CardboardStore.removeListener("fetched_pages_count", this.getNumOfPages);
    CardboardStore.removeListener("hide_add_bar", this.hideAddBar);
    CardboardStore.removeListener("hide_edit_bar", this.hideEditBar);
    CardboardStore.removeListener(
      "hide_add_daily_entry_bar",
      this.hideAddDailyEntryBar
    );
    CardboardStore.removeListener("unauthorized", this.redirectToLogin);
  }

  redirectToLogin() {
    localStorage.clear();
    this.props.history.push("/login");
  }

  getCartons() {
    this.setState({
      catons: CardboardStore.getAll()
    });
  }

  evaluation() {
    if (this.state.selectedRow.id) {
      this.props.history.push("/evaluation/" + this.state.selectedRow.id);
    }
  }

  getNumOfPages() {
    this.setState({ totalPages: CardboardStore.getNumOfPages() });
  }

  hideAddBar() {
    this.setState({ showAddSide: false });
  }

  hideAddDailyEntryBar() {
    this.setState({ showAddDailyEntry: false });
  }

  hideEditBar() {
    this.setState({ showEditSide: false });
  }

  onItemSelected(selectedRow) {
    this.setState({ selectedRow, showEditSide: true });
  }

  showAddSide() {
    this.setState({ showAddSide: true });
  }

  showAddDailyEntry() {
    if (this.state.selectedRow.id) {
      this.setState({ showAddDailyEntry: true });
    }
  }

  onPreviousClick() {
    let { currentPage } = this.state;
    if (currentPage > 1) {
      this.setState({ currentPage: --currentPage });
    }
    CardboardActions.getCartons(currentPage);
  }

  onPageClick(page) {
    this.setState({ currentPage: page });
    CardboardActions.getCartons(page);
  }

  onNextClick() {
    let { currentPage, totalPages } = this.state;
    if (currentPage < totalPages) {
      this.setState({ currentPage: ++currentPage });
    }

    CardboardActions.getCartons(currentPage);
  }

  render() {
    return (
      <main className="main">
        {this.state.showAddSide && <Overlay />}
        <Header>
			<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 100 100" preserveAspectRatio="none">
				<polygon fill="rgb(248,249,252)" points="0,0 30,100 65,21 90,100 100,75 100,100 0,100"/>
				<polygon fill="rgb(248,249,252)" points="0,0 15,100 33,21 45,100 50,75 55,100 72,20 85,100 95,50 100,80 100,100 0,100" />
			</svg> 
		</Header>
        <div className="container wrap">
          <Container>
		   <ButtonContainer>
			   <div onClick={this.showAddDailyEntry}>Dodaj dnevni unos za gosta</div>
			   <div onClick={this.showAddSide}>Dodaj karton</div>
			   <div onClick={this.evaluation}>Procena</div>
		   </ButtonContainer>
            <div className="table-carton">
              <table className="table table-position">
                <TableHeader />
                <TableData
                  data={this.state.catons}
                  selectItem={this.onItemSelected}
                />
              </table>
            </div>
            <Pagination
              totalPages={this.state.totalPages}
              previousClick={this.onPreviousClick}
              pageClick={this.onPageClick}
              nextClick={this.onNextClick}
              currentPage={this.state.currentPage}
            />
          </Container>
        </div>

        <AddCartonSide
          open={this.state.showAddSide}
          pageNumber={this.state.currentPage}
        />
        {this.state.showEditSide && (
          <EditCartonSide
            open={this.state.showEditSide}
            data={this.state.selectedRow}
            pageNumber={this.state.currentPage}
          />
        )}

        {this.state.showAddDailyEntry && (
          <AddDailyEntry
            open={this.state.showAddDailyEntry}
            data={this.state.selectedRow}
            pageNumber={this.state.currentPage}
          />
        )}
        <div className="carton-table-edit" />
      </main>
    );
  }
}

export default withRouter(CartonTable);
